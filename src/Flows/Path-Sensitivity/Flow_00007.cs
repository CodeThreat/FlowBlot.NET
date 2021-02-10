namespace FlowBlot.Flows
{
    public class Flow_00007
    {
        public void Run()
        {
            string input = System.String.Empty;
            if (5 > 1)
            {
                input = FlowBlot.Model.Framework.Source();
            }
            /*FLOW:Flow_00007 - A hard-code if taint propagation:codethreat.flowblot.benchmark:3:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(input);
        }
    }
}
