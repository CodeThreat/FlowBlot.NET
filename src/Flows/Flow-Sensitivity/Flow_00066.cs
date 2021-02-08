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

            /*FLOW:Flow_00066 - A flow-sensitive points-to analysis taint propagation:OS Command Injection:0:NONE:0:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(a.n);
        }
    }
}
