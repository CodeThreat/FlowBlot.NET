using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00057
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            D a = new D();
            D b = new D();
            b.x = input;

            F f = new F(a);
            f.ReInitialize(b);
            D c = f.Get();

            /*FLOW:Flow_00057 - A inheritance based alias analysis FP taint propagation:codethreat.flowblot.benchmark:13:FIND_ISSUE:1:
              *STEP_PATH:ABC
              */
            FlowBlot.Model.Framework.Sink(c.x);
        }
    }
}
