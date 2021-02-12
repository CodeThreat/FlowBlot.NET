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
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            MyThread obj = new MyThread();

            Thread thr = new Thread(obj.Consume);
            thr.Start(input);
        }
    }

    public class MyThread
    {
        public void Consume(object input)
        {
            /*FLOW:Flow_00074 - A basic flow with threads:codethreat.flowblot.benchmark:5:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink((string)input);
        }
    }
}
