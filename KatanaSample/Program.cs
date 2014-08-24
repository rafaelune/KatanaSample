using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KatanaSample
{
    public class Program
    {
        private static ManualResetEvent _quitEvent = new ManualResetEvent(false);

        static void Main(string[] args)
        {
            var port = 5000;
            if (args.Length > 0)
            {
                int.TryParse(args[0], out port);
            }

            Console.CancelKeyPress += (sender, eArgs) =>
            {
                _quitEvent.Set();
                eArgs.Cancel = true;
                Console.WriteLine("Server stopped");
            };

            using (WebApp.Start<Startup>(string.Format("http://*:{0}", port)))
            {
                Console.WriteLine("Server started");
                Console.WriteLine("Press any key to exit");
                _quitEvent.WaitOne();
            }
        }
    }
}
