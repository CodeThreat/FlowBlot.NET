using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00045
    {
        public const string ID = "00045"; 
        public const string Description = "A points-to analysis taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            Blot blot1 = new Blot();
            Blot blot3 = blot1;

            blot1.Name = System.Console.ReadLine();

            Blot blot2 = blot3;

            System.Diagnostics.Process.Start(blot2.Name);
        }
    }
}
