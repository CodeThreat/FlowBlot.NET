namespace FlowBlot.Flows
{
    public class Flow_00037
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            try
            {
                input = input.Substring(1, 5);
            }
            catch(System.Exception e)
            {
                /*FLOW:Flow_00037 - An exception handler taint propagation:codethreat.flowblot.benchmark:4:FIND_ISSUE:1:
                *STEP_PATH:ABC
                */
                FlowBlot.Model.Framework.Sink(input);
            }
        }
    }
}
