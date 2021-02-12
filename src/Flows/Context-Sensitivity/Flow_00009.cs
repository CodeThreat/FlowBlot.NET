using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00009
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();
            BlotBag blotBag = new BlotBag();
            Blot newBlot = new Blot();
            newBlot.Name = input;
            blotBag.Put(newBlot);

            /*FLOW:Flow_00009 - A context-sensitivity taint propagation:codethreat.flowblot.benchmark:8:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(blotBag.GetFirst().Name);
        }
    }
}
