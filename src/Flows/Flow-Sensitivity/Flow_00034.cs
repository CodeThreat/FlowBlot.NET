namespace FlowBlot.Flows
{
    public class Flow_00034
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            input = System.String.Empty;

            /*FLOW:Flow_00034 - A flow-sensitive FP taint propagation:codethreat.flowblot.benchmark:4:FIND_ISSUE:1:
            *STEP_PATH:ABC
            */
            FlowBlot.Model.Framework.Sink(input);
        }
    }
}
