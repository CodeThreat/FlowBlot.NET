namespace FlowBlot.Flows
{
    public class Flow_00070
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            int a = 1;
            int b = 5;

            if (a >= b)            
            {
                input = System.String.Empty;
            }

            /*FLOW:Flow_00070 - A flow-sensitivity vs path-sensitivity taint propagation:codethreat.flowblot.benchmark:4:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(input);
        }
    }
}
