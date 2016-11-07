using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SubscriberNamespace
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.Sleep(6000);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Subscriber());
        }
    }
}