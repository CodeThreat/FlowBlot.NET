using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00068
    {
        public void Run()
        {
            var blot1 = new Blot();
            var blot2 = new Blot();

            blot2.Name = FlowBlot.Model.Framework.Source();

            blot2 = blot1;

            /*FLOW:Flow_00068 - A flow-sensitive points-to analysis FP taint propagation:codethreat.flowblot.benchmark:4:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(blot2.Name);
        }
    }
}
