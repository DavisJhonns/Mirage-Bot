using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using static Mirage_Bot.Classes.DataManager;
//using static Mirage_Bot.Classes.PyRunner;

namespace Mirage_Bot.Classes
{
    partial class MirageBot
    {
        private List<Item> Items;
        private List<UIObject> UIObjects;
        private List<Timer> TimerList;
        private void InitalizeItems(string[] resource, bool[] activeButtons)
        {
            this.Items = new List<Item>();
            for (int i = 0; i < resource.Length; i++)
            {
                var e = resource[i].Split('|')[1].Split(',');
                string name = e[0];
                char hotkey = Convert.ToChar(e[1]);
                int cooldown = Convert.ToInt32(e[2]);
                bool isActive = activeButtons[i];
                this.Items.Add(new Item(name, hotkey, cooldown, isActive));
            }
            //foreach (var item in resource)
            //{
            //    var e = item.Split('|')[1].Split(',');
            //    string name = e[0];
            //    char hotkey = Convert.ToChar(e[1]);
            //    int cooldown = Convert.ToInt32(e[2]);
            //    this.Items.Add(new Item(name, hotkey, cooldown));
            //}
        }
        private void InitalizeIUIObjects(string[] resource)
        {
            this.UIObjects = new List<UIObject>();
            foreach (var item in resource)
            {
                var e = item.Split('|')[1].Split(',');
                string name = e[0];
                int[] position = new int[] { Convert.ToInt32(e[1]), Convert.ToInt32(e[2]) };
                byte[] color = new byte[] { Convert.ToByte(e[3]), Convert.ToByte(e[4]), Convert.ToByte(e[5]) };
                bool isHasAction = e.Length < 5;
                if (isHasAction) this.UIObjects.Add(new UIObject(name, position, color, new string[] { e[6] }));
                else this.UIObjects.Add(new UIObject(name, position, color));
            }
        }
        private void InitalizeTimers()
        {
            this.TimerList = new List<Timer>();
            foreach (var item in Items)
            {
                TimerList.Add(CreateTimer(item.ID, item.Cooldown, Timer_Tick));
            }
        }
        public MirageBot(bool[] activeButtons)
        {
            string[] data = LoadResources(@"..\..\source\settings.txt");
            InitalizeItems(data.Where(e => e.Split('|')[0] == "item").ToArray(), activeButtons);
            InitalizeIUIObjects(data.Where(e => e.Split('|')[0] == "ui").ToArray());
            InitalizeTimers();
            //PyRunner.Init();
        }
    }
    partial class MirageBot
    {
        private class Item
        {
            private const string Type = "item";
            private string name { get; set; }
            private char hotkey { get; set; }
            private int cooldown { get; set; }
            private bool isActive { get; set; }
            public string ID { get { return this.name.ToLower(); } }
            public string Name { get { return this.name; } set { this.name = value; } }
            public char Hotkey { get { return this.hotkey; } set { this.hotkey = value; } }
            public int Cooldown { get { return this.cooldown; } set { this.cooldown = value; } }
            public bool IsActive { get { return isActive; } set { this.isActive = value; } }
            /// <summary>
            /// Creates an Item
            /// </summary>
            /// <param name="name">is item name</param>
            /// <param name="hotkey">is hotkey</param>
            /// <param name="cooldown">is use cooldown</param>
            /// <param name="isActive">is if active</param>
            public Item(string name, char hotkey, int cooldown, bool isActive)
            {
                this.name = name;
                this.hotkey = hotkey;
                this.cooldown = cooldown;
                this.isActive = isActive;
            }
            public string GetStringFormat() => $"{Type}|{this.name},{this.hotkey},{this.cooldown}";
        }
        private class UIObject
        {
            private class ColorObj
            {
                private byte r;
                private byte g;
                private byte b;
                public byte R { get { return r; } set { r = value; } }
                public byte G { get { return g; } set { g = value; } }
                public byte B { get { return b; } set { b = value; } }
                public byte[] RGB { get { return new byte[3] { r, g, b }; } }
                public ColorObj(byte[] RGB)
                {
                    try
                    {
                        this.r = RGB[0];
                        this.g = RGB[1];
                        this.b = RGB[2];
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            private const string Type = "ui";
            private string name { get; set; }
            private int[] position { get; set; }
            private ColorObj color { get; set; }
            private string[] action { get; set; }
            public string ID { get { return name.ToLower(); } }
            public string Name { get { return name; } set { name = value; } }
            public int[] Position { get { return position; } set { position = value; } }
            public object Color { get { return color; } set { color = value as ColorObj; } }
            public string[] Action { get { return action; } set { action = value; } }
            /// <summary>
            /// Default constructor. Creates a UIObject
            /// </summary>
            /// <param name="Name"> is UIObject name</param>
            /// <param name="Position"> is position of the pixel</param>
            /// <param name="Color"> is minimum intervall when need to do actions</param>
            public UIObject(string name, int[] position, byte[] color)
            {
                this.name = name;
                this.position = position;
                this.color = new ColorObj(color);
            }
            /// <summary>
            /// Creates a UIObject
            /// </summary>
            /// <param name="Name"> is UIObject name</param>
            /// <param name="Position"> is position of the pixel</param>
            /// <param name="Color"> is minimum intervall when need to do actions</param>
            /// <param name="Action">is key action</param>
            public UIObject(string name, int[] position, byte[] color, string[] action)
            {
                this.name = name;
                this.position = position;
                this.color = new ColorObj(color);
                this.action = action;
            }
            public string GetStringFormat() => $"{Type}|{this.name},{this.position[0]},{this.position[1]},{this.color.R},{this.color.G},{this.color.B}" + this.action != null ? $",{this.action}" : "";
        }
    }
    partial class MirageBot
    {
        private Timer CreateTimer(string tag, int intervall, EventHandler eh)
        {
            Timer t = new Timer() { Tag = tag, Interval = intervall };
            t.Tick += new EventHandler(eh);
            return t;
        }
        public void StartTimers()
        {
            foreach (var t in TimerList)
            {
                if (Items.Find(f => f.ID == t.Tag.ToString()).IsActive) t.Start();
            }
        }
        public void StopTimers()
        {
            foreach (var t in TimerList)
            {
                t.Stop();
            }
        }
        public void ToggleTimer(string tag)
        {
            Timer t = TimerList.Find(f => f.Tag.ToString() == tag);
            int i = Items.IndexOf(Items.Find(f => f.ID == tag));
            try
            {
                this.Items[i].IsActive = !this.Items[i].IsActive;
                if (Items[i].IsActive)
                {
                    t.Stop();
                }
                else
                {
                    t.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer t = sender as Timer;
            char hotkey = Items.Find(f => f.ID == t.Tag.ToString()).Hotkey;
            Stroker.Key(hotkey);
        }
    }
}
