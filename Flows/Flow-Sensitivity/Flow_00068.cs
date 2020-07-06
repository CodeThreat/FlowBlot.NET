using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00068
    {
        public const string ID = "00068"; 
        public const string Description = "A flow-sensitive points-to analysis FP taint propagation";
        public const bool IsVulnerable = false;

        public void Run()
        {
            var blot1 = new Blot();
            var blot2 = new Blot();

            blot2.Name = System.Console.ReadLine();

            blot2 = blot1;

            System.Diagnostics.Process.Start(blot2.Name);
        }
    }
}
