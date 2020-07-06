using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlowBlot.Flows
{
    public class Flow_00074
    {
        public const string ID = "00074";
        public const string Description = "A basic flow with threads";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();

            MyThread obj = new MyThread();

            Thread thr = new Thread(obj.Consume);
            thr.Start(input);
        }
    }

    public class MyThread
    {
        public void Consume(object input)
        {
            System.Diagnostics.Process.Start((string)input);
        }
    }
}
