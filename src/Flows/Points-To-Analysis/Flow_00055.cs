using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00055
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            D a = new D();
            D b = new D();
            b.x = input;

            E e = new E(a);
            e.ReInitialize(b);
            D c = e.Get();

            /*FLOW:Flow_00055 - A basic alias analysis taint propagation:codethreat.flowblot.benchmark:0+:FIND_ISSUE:1:
              *STEP_PATH:ABC
              */
            FlowBlot.Model.Framework.Sink(c.x);
        }
    }
}
