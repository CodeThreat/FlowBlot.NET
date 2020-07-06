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

            System.Diagnostics.Process.Start(c.x);
        }
    }
}
