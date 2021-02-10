using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00032
    {
        public void Run()
        {
            Blot blot1 = new Blot();
            Blot blot2 = blot1;

            blot1.Name = FlowBlot.Model.Framework.Source();

            /*FLOW:Flow_00032 - A points-to analysis taint propagation:codethreat.flowblot.benchmark:5:FIND_ISSUE:1:
            *STEP_PATH:ABC
            */
            FlowBlot.Model.Framework.Sink(blot2.Name);
        }
    }
}
