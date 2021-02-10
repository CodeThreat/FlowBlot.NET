using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00036
    {
        // flow insensitive points-to analysis lead to FP
        // in other words; non-deterministic choice of the if branch and may-alias points-to analysis leads to FP

        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            A b, q, y;
            B a, p, x;

            a = new B();
            p = new B();

            b = new A();
            q = new A();

            if ((new System.Random()).Next(0,1) < 0.5)
            {
                x = a;
                y = b;
            }
            else
            {
                x = p;
                y = q;
            }

            x.attr = y;
            q.b = input;

            /*FLOW:Flow_00036 - A shuffling points-to analysis FP taint propagation:codethreat.flowblot.benchmark:0:NONE:0:0
            *STEP_PATH:ABC
            */
            FlowBlot.Model.Framework.Sink(a.attr.b);
        }

    }
}
