using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00066
    {
        public const string ID = "00066";
        public const string Description = "A flow-sensitive points-to analysis taint propagation";
        public const bool IsVulnerable = false; 

        public void Run()
        {
            string input = System.Console.ReadLine();

            N a = new M();
            var b = a;
            b.n = input;
            a = new O();

            System.Diagnostics.Process.Start(a.n);
        }
    }
}
