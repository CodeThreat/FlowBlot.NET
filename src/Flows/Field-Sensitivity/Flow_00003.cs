using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00003
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();
            Blot aBlot = new Blot();
            aBlot.Name = input;

            /*FLOW:Flow_00003 - A field-sensitive taint propagation:codethreat.flowblot.benchmark:5:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(aBlot.Name);
        }
    }
}
