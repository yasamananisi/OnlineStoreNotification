using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace Publisher
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Thread.Sleep(3000);
            Application.Run(new PublisherForm());
        }
    }
}