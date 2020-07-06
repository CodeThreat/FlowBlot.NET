using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00032
    {
        public const string ID = "00032"; 
        public const string Description = "A points-to analysis taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            Blot blot1 = new Blot();
            Blot blot2 = blot1;

            blot1.Name = System.Console.ReadLine();

            System.Diagnostics.Process.Start(blot2.Name);
        }
    }
}
