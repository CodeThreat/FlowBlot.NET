using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00048
    {
        public const string ID = "00048"; 
        public const string Description = "A complex points-to analysis FP taint propagation";
        public const bool IsVulnerable = false;

        public void Run()
        {
            FirstDrill();
            SecondDrill();
        }

        private void FirstDrill()
        {
            C a = new C();
            C b = new C();
            string input = System.Console.ReadLine();
            Mix(a, b, input);
        }

        private void SecondDrill()
        {
            C a = new C();
            C b = a;
            string input = "My";
            Mix(a, b, input);
        }

        private void Mix(C a, C b, string n)
        {
            a.x = n;

            /*FLOW:Flow_00048 - A complex points-to analysis FP taint propagation:OS Command Injection:0:NONE:0:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(b.x);
        }

    }
}
