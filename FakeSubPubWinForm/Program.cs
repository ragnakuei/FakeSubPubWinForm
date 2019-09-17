using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FakePubSub.PubSubWorker;

namespace FakeSubPubWinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var pubSubStore = new PubSubStore();
            Application.Run(new Form1(pubSubStore));
        }
    }
}
