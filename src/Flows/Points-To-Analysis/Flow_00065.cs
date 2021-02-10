using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00065
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            var c = new A();

            var d = c;

            var e = d;

            d.b = input;

            var f = e;

            /*FLOW:Flow_00065 - A complex points-to analysis taint propagation:codethreat.flowblot.benchmark:9:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(f.b);
        }
    }
}
