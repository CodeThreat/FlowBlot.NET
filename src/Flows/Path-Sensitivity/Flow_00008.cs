namespace FlowBlot.Flows
{
    public class Flow_00008
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();            
            if (5 > 1)
            {
                input = System.String.Empty;
            }

            /*FLOW:Flow_00008 - A hard-coded if FP taint propagation:codethreat.flowblot.benchmark:4:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(input);
        }
    }
}
