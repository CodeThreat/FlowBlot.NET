using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00056
    {
        public const string ID = "00056";
        public const string Description = "A basic alias analysis FP taint propagation";
        public const bool IsVulnerable = false;

        public void Run()
        {
            string input = System.Console.ReadLine();

            D a = new D();
            a.x = input;
            D b = new D();

            E e = new E(a);
            e.ReInitialize(b);
            D c = e.Get();

            System.Diagnostics.Process.Start(c.x);
        }
    }
}
