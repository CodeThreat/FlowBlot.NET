using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00075
    {
        public void Run()
        {
            Blot blot1 = new Blot();
            Blot blot2 = null;

            Assign(blot1, blot2);

            blot1.Name = FlowBlot.Model.Framework.Source();

            /*FLOW:Flow_00075 - A points-to analysis taint propagation using an assign function:codethreat.flowblot.benchmark:0+:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(blot2.Name);
        }


        public void Assign(Blot b1, Blot b2)
        {
            b2 = b1;
        }
    }
}
