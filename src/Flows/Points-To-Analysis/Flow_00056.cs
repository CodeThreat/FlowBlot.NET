using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00056
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            D a = new D();
            a.x = input;
            D b = new D();

            E e = new E(a);
            e.ReInitialize(b);
            D c = e.Get();

            /*FLOW:Flow_00056 - A basic alias analysis FP taint propagation:codethreat.flowblot.benchmark:0:NONE:0:
              *STEP_PATH:ABC
              */
            FlowBlot.Model.Framework.Sink(c.x);
        }
    }
}
