using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00047
    {
        public const string ID = "00047"; 
        public const string Description = "A complex points-to analysis taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            FirstDrill();
            SecondDrill();
        }

        private void FirstDrill()
        {
            C a = new C();
            C b = a;
            string input = System.Console.ReadLine();
            Mix(a, b, input);
        }

        private void SecondDrill()
        {
            C a = new C();
            C b = new C();
            string input = "My";
            Mix(a, b, input);
        }

        private void Mix(C a, C b, string n)
        {
            a.x = n;
            System.Diagnostics.Process.Start(b.x);
        }

    }
}
