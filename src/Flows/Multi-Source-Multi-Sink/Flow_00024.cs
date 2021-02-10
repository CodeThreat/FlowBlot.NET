namespace FlowBlot.Flows
{
    public class Flow_00024
    {
        public void Run(string input)
        {
            input += FlowBlot.Model.Framework.Source();


            /*FLOW:Flow_00024 - A multi source taint propagation:codethreat.flowblot.benchmark:3:FIND_ISSUE:1:2:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(input);
        }
    }
}
