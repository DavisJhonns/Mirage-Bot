using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Mirage_Bot.Classes;
using Mirage_Bot.Settings_Form;

namespace Mirage_Bot
{
    public partial class MirageBotUI_form : Form
    {
        private class ButtonStates
        {
            private bool[] states { get; set; }
            public bool HP { get { return states[0]; } }
            public bool MP { get { return states[1]; } }
            public bool Skill1 { get { return states[2]; } }
            public bool Skill2 { get { return states[3]; } }
            public bool Skill3 { get { return states[4]; } }
            public bool Rune { get { return states[5]; } }
            public bool Food { get { return states[6]; } }
            public bool[] GetAll { get { return states; } }
            public ButtonStates()
            {
                this.states = new bool[7] { false, false, false, false, false, false, false };
            }
            public bool Get(int i)
            {
                try { return this.states[i]; }
                catch (Exception e) { Console.WriteLine(e); }
                return false;
            }
            public void Toggle(int i)
            {
                try { this.states[i] = !this.states[i]; }
                catch (Exception e) { Console.WriteLine(e); }
            }
        }
        private ButtonStates States;
        private bool isActive;
        private DateTime Time;
        private MirageBot MBot;
        private Settings_form SettingsForm;
        public MirageBotUI_form()
        {
            InitializeComponent();
            this.SettingsForm = new Settings_form();
        }
        private void MirageBotUI_form_Load(object sender, EventArgs e)
        {
            this.States = new ButtonStates();
            this.isActive = false;
            //BackColor = Stroker.GetColorAt(100, 100);
            //MessageBox.Show(Stroker.GetColorAt(10, 10));
        }
        private void Duration_Timer_Tick(object sender, EventArgs e)
        {
            string h = (DateTime.Now - Time).Hours.ToString();
            string m = (DateTime.Now - Time).Minutes.ToString();
            string s = (DateTime.Now - Time).Seconds.ToString();
            Time_lb.Text = $"{Format(h)}:{Format(m)}:{Format(s)}";
        }
        private void Operator_btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            this.isActive = !this.isActive;
            if (this.isActive)
            {
                Player.Load();
                this.Time = DateTime.Now;
                Duration_timer.Start();
                MakeActiveButton(btn, Color.Lime, "Running...");
                MBot = new MirageBot(States.GetAll);
                MBot.StartTimers();
            }
            else
            {
                Player.Unselect();
                Duration_timer.Stop();
                MakeActiveButton(btn, Color.BlueViolet, "Start");
                MBot.StopTimers();
            }
        }
        private void Scrpit_Buttons_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            States.Toggle(btn.TabIndex);
            if (States.Get(btn.TabIndex))
            {
                Player.Select();
                MakeActiveButton(btn, Color.Lime);
                if (this.isActive) MBot.ToggleTimer(btn.Tag.ToString());
            }
            else
            {
                Player.Unselect();
                MakeActiveButton(btn, Color.BlueViolet);
                if (this.isActive) MBot.ToggleTimer(btn.Tag.ToString());
                //if (!this.isActive) MBot.ToggleTimer(btn.Tag.ToString());
            }
        }
        private void Settings_mi_Click(object sender, EventArgs e)
        {
            SettingsForm.Show();
        }
        private void MakeActiveButton(Button btn, Color color, string text = null)
        {
            if (color != null) btn.ForeColor = color;
            if (text != null) btn.Text = text;
        }
        private string Format(string value) => (value.Length == 1) ? $"0{value}" : value;
    }
}
