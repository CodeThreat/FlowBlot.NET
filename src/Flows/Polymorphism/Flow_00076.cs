using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00076
    {
        public void Run()
        {
            Robot robot = new Robot();
            robot.Pause();
        }

        public void PauseMachine(Machine machine)
        {
            machine.Pause();
            string name = machine.SayName();

            /*FLOW:Flow_00076 - An inheritance based taint propagation:codethreat.flowblot.benchmark:0:NONE:0:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(name);
        }
    }
}
