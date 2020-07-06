using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00003
    {
        public const string ID = "00003";
        public const string Description = "A field-sensitive taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();
            Blot aBlot = new Blot();
            aBlot.Name = input;
            System.Diagnostics.Process.Start(aBlot.Name);
        }
    }
}
