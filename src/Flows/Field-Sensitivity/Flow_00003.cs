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

            /*FLOW:Flow_00003 - A field-sensitive taint propagation:OS Command Injection:5:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(aBlot.Name);
        }
    }
}
