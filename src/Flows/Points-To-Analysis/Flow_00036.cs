using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00036
    {
        public const string ID = "00036"; 
        public const string Description = "A shuffling points-to analysis FP taint propagation";
        // flow insensitive points-to analysis lead to FP
        // in other words; non-deterministic choice of the if branch and may-alias points-to analysis leads to FP
        public const bool IsVulnerable = false;

        public void Run()
        {
            string input = System.Console.ReadLine();

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

            /*FLOW:Flow_00036 - A shuffling points-to analysis FP taint propagation:OS Command Injection:0:NONE:0:0
            *STEP_PATH:ABC
            */
            System.Diagnostics.Process.Start(a.attr.b);
        }

    }
}
