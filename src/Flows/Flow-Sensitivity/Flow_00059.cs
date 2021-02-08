using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00059
    {
        public const string ID = "00059";
        public const string Description = "A flow-sensitive FP taint propagation";
        public const bool IsVulnerable = false;

        public void Run()
        {
            string input = System.Console.ReadLine();

            A a = new A();
            a.b = input;
            A b = new A();

            /*FLOW:Flow_00059:OS Command Injection:0:NONE:0:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(b.b);
            b = a;
        }
    }
}
