using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00067
    {
        public void Run()
        {
            Blot blot1 = new Blot();
            Blot blot2 = new Blot();

            blot1.Name = FlowBlot.Model.Framework.Source();

            /*FLOW:Flow_00067 - A points-to analysis FP taint propagation:codethreat.flowblot.benchmark:0:NONE:0:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(blot2.Name);
        }
    }
}
