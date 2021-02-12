using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00022
    {
        public void Run()
        {
            Atlas atlas = new Atlas();
            atlas.name = FlowBlot.Model.Framework.Source();

            Machine machine = Build(atlas);

            string input = ((Atlas)machine).SayName();



            /*FLOW:Flow_00022 - A inter-procedural polymorphic taint propagation:codethreat.flowblot.benchmark:8:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(input);
        }

        public Machine Build(Machine machine)
        {
            return machine;
        }

    }
}
