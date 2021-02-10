using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00010
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            BlotBag blotBag = new BlotBag();
            Blot newBlot = new Blot();
            newBlot.Name = input;
            blotBag.Put(newBlot);

            BlotBag blotBag2 = new BlotBag();
            Blot newBlot2 = new Blot();
            newBlot2.Name = System.String.Empty;
            blotBag2.Put(newBlot2);

            /*FLOW:Flow_00010 - A context-sensitive FP taint propagation:codethreat.flowblot.benchmark:9:NONE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(blotBag2.GetFirst().Name);
        }
    }
}
