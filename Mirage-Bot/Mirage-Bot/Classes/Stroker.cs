using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;

namespace Mirage_Bot.Classes
{
    public static class Stroker
    {
        #region Dll Import
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("USER32.DLL")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern uint GetPixel(IntPtr dc, int x, int y);
        #endregion

        #region Statics
        private const UInt32 WM_KEYDOWN = 0x0100;
        private const UInt32 WM_KEYUP = 0x0101;
        private const string WindowName = "Mirage Realms - Early Access v0.8.14";
        #endregion
        public static void _Key(char key)
        {
            IntPtr Window = FindWindow(null, WindowName);

            if (SetForegroundWindow(Window))
                SendKeys.Send(key.ToString());
        }
        public static void Key(char key)
        {
            IntPtr hwnd = FindWindow(null, WindowName);
            PostMessage(hwnd, WM_KEYDOWN, (int)key, 0);
            PostMessage(hwnd, WM_KEYUP, (int)key, 0);
        }
        public static Color _GetColorAt(int x, int y)
        {
            IntPtr hwnd = FindWindow(null, WindowName);
            int a = (int)GetPixel(hwnd, x, y);
            //ReleaseDC(desk, dc);
            return Color.FromArgb(255, (a >> 0) & 0xff, (a >> 8) & 0xff, (a >> 16) & 0xff);
        }
        public static Color test_GetColorAt(int x, int y)
        {
            Bitmap bmp = new Bitmap(1, 1);
            Rectangle bounds = new Rectangle(x, y, 1, 1);
            IntPtr hwnd = FindWindow(null, WindowName);
            Bitmap b = new Bitmap(1, 1, 1, System.Drawing.Imaging.PixelFormat.DontCare, hwnd);
            //using (Graphics g = Graphics.FromHwnd(hwnd))
            //{
            //    g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            //}
            return b.GetPixel(0, 0);
        }
        public static Color GetColorAt(int x, int y)
        {
            Bitmap bmp = new Bitmap(1, 1);
            Rectangle bounds = new Rectangle(x, y, 1, 1);
            using (Graphics g = Graphics.FromImage(bmp))
                g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            return bmp.GetPixel(0, 0);
        }
    }
}
