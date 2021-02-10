using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00066
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            N a = new M();
            var b = a;
            b.n = input;
            a = new O();

            /*FLOW:Flow_00066 - A flow-sensitive points-to analysis taint propagation:codethreat.flowblot.benchmark:0:NONE:0:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(a.n);
        }
    }
}
