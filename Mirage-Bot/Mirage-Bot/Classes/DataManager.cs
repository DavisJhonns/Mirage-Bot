using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Mirage_Bot.Classes
{
    public static class DataManager
    {
        // default path: @"source\settings.txt"
        public static string[] LoadResources(string path)
        {
            List<string> file = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        file.Add(sr.ReadLine());
                    }
                    sr.Close();
                }
                return file.ToArray();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            //return file.ToArray();
            return null;
        }
        public static void UpdateResources(string path, string[] data)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (var item in data)
                    {
                        sw.WriteLine(data);
                    }
                    sw.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }
    }
}
