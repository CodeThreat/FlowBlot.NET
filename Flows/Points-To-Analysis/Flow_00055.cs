using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00055
    {
        public const string ID = "00055";
        public const string Description = "A basic alias analysis taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();

            D a = new D();
            D b = new D();
            b.x = input;

            E e = new E(a);
            e.ReInitialize(b);
            D c = e.Get();

            System.Diagnostics.Process.Start(c.x);
        }
    }
}
