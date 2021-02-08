using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00065
    {
        public const string ID = "00065";
        public const string Description = "A complex points-to analysis taint propagation";
        public const bool IsVulnerable = true; 

        public void Run()
        {
            string input = System.Console.ReadLine();

            var c = new A();

            var d = c;

            var e = d;

            d.b = input;

            var f = e;

            /*FLOW:Flow_00065 - A complex points-to analysis taint propagation:OS Command Injection:9:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(f.b);
        }
    }
}
