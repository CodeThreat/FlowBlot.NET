using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00059
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            A a = new A();
            a.b = input;
            A b = new A();

            /*FLOW:Flow_00059 - A flow-sensitive FP taint propagation:codethreat.flowblot.benchmark:0:NONE:0:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(b.b);
            b = a;
        }
    }
}
