using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00069
    {
        public void Run()
        {
            var blot1 = new Blot();

            blot1.Name = FlowBlot.Model.Framework.Source();


            /*FLOW:Flow_00069 - A field-sensitive points-to analysis FP taint propagation:codethreat.flowblot.benchmark:3:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(blot1.Description);
        }
    }
}
