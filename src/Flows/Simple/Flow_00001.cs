namespace FlowBlot.Flows
{
    public class Flow_00001
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            /*FLOW:Flow_00001 - A Basic source to sink taint propagation:codethreat.flowblot.benchmark:3:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(input);
        }
    }
}
