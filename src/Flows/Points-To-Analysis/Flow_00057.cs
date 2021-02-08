using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00057
    {
        public const string ID = "00057";
        public const string Description = "A inheritance based alias analysis FP taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();

            D a = new D();
            D b = new D();
            b.x = input;

            F f = new F(a);
            f.ReInitialize(b);
            D c = f.Get();

            /*FLOW:Flow_00057 - A inheritance based alias analysis FP taint propagation:OS Command Injection:0+:FIND_ISSUE:1:
              *STEP_PATH:ABC
              */
            System.Diagnostics.Process.Start(c.x);
        }
    }
}
