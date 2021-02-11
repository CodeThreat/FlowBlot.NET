
namespace FlowBlot.Flows
{
    public class Flow_00026
    {
        public void Run(string input)
        {

            /*FLOW:Flow_00026 - A multi sink taint propagation:codethreat.flowblot.benchmark:7:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(input);
        }
    }
}
