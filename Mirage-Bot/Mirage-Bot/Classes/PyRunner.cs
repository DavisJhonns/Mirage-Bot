using System;
using System.IO;
using Python.Runtime;

namespace Mirage_Bot.Classes
{
    public static class PyRunner
    {
        //public static void Init(string pyDll = @"C:\Users\davis\AppData\Local\Programs\Python\Python312\python312.dll")
        //{
        //    try
        //    {
        //        PyDll = pyDll;
        //    }
        //    catch(Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }
        //}
        public static void Run(string method, string hotkey)
        {
            Runtime.PythonDLL = @"C:\Users\davis\AppData\Local\Programs\Python\Python312\python312.dll";
            PythonEngine.Initialize();
            PythonEngine.BeginAllowThreads();
            using (Py.GIL())
            {
                var pyscript = Py.Import(@"..\..\source\bot");
                pyscript.InvokeMethod(method, new PyObject[] { new PyString(hotkey) });
            }
        }
    }
}
