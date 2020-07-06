using System;
using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00046
    {
        public const string ID = "00046"; 
        public const string Description = "A complex alias shuffling points-to analysis taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();

            A b, q, y;
            B a, p, x;

            a = new B();
            p = new B();

            b = new A();
            q = new A();

            if ((new Random()).Next(0, 1) < 0.5f)
            {
                x = a;
                y = q;
            }
            else
            {
                x = p;
                y = b;
            }

            x.attr = y;
            q.b = input;

            System.Diagnostics.Process.Start(a.attr.b);
        }

    }
}
