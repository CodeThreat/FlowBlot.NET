using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00069
    {
        public const string ID = "00069"; 
        public const string Description = "A field-sensitive points-to analysis FP taint propagation";
        public const bool IsVulnerable = false;

        public void Run()
        {
            var blot1 = new Blot();

            blot1.Name = System.Console.ReadLine();

            System.Diagnostics.Process.Start(blot1.Description);
        }
    }
}
