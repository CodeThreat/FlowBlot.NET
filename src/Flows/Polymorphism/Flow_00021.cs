using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00021
    {
        public void Run()
        {
            Machine machine = new Robot();
            Robot robot = (Robot)machine;
            robot.name = FlowBlot.Model.Framework.Source();

            string input = robot.name;

            /*FLOW:Flow_00021 - A polymorphic taint propagation:codethreat.flowblot.benchmark:5:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(input);
        }

    }
}
