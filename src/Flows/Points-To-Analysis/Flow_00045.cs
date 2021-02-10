using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00045
    {
        public void Run()
        {
            Blot blot1 = new Blot();
            Blot blot3 = blot1;

            blot1.Name = FlowBlot.Model.Framework.Source();

            Blot blot2 = blot3;


            /*FLOW:Flow_00045 - A points-to analysis taint propagation:codethreat.flowblot.benchmark:7:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(blot2.Name);
        }
    }
}
