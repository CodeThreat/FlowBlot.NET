using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00004
    {
        public const string ID = "00004";
        public const string Description = "A field-sensitive FP taint propagation";
        public const bool IsVulnerable = false;

        public void Run()
        {
            string input = System.Console.ReadLine();
            Blot aBlot = new Blot();
            aBlot.Description = input;
            System.Diagnostics.Process.Start(aBlot.Name);
        }
    }
}
