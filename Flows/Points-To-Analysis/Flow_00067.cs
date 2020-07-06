using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00067
    {
        public const string ID = "00067"; 
        public const string Description = "A points-to analysis FP taint propagation";
        public const bool IsVulnerable = false;

        public void Run()
        {
            Blot blot1 = new Blot();
            Blot blot2 = new Blot();

            blot1.Name = System.Console.ReadLine();

            System.Diagnostics.Process.Start(blot2.Name);
        }
    }
}
