using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00009
    {
        public const string ID = "00009";
        public const string Description = "A context-sensitivity taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();

            BlotBag blotBag = new BlotBag();
            Blot newBlot = new Blot();
            newBlot.Name = input;
            blotBag.Put(newBlot);

            /*FLOW:Flow_00009 - A context-sensitivity taint propagation:OS Command Injection:9:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(blotBag.GetFirst().Name);
        }
    }
}
