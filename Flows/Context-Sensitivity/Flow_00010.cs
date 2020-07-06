using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00010
    {
        public const string ID = "00010";
        public const string Description = "A context-sensitive FP taint propagation";
        public const bool IsVulnerable = false;

        public void Run()
        {
            string input = System.Console.ReadLine();

            BlotBag blotBag = new BlotBag();
            Blot newBlot = new Blot();
            newBlot.Name = input;
            blotBag.Put(newBlot);

            BlotBag blotBag2 = new BlotBag();
            Blot newBlot2 = new Blot();
            newBlot2.Name = System.String.Empty;
            blotBag2.Put(newBlot2);

            System.Diagnostics.Process.Start(blotBag2.GetFirst().Name);
        }
    }
}
