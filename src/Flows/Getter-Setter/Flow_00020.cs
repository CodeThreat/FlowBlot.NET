using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00020
    {
        public void Run()
        {
            Blot blot = new Blot();
            blot.Viscosity = FlowBlot.Model.Framework.Source();


            /*FLOW:Flow_00020 - A setter FP taint propagation:codethreat.flowblot.benchmark:0:NONE:0:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(blot.Viscosity);
        }

    }
}
