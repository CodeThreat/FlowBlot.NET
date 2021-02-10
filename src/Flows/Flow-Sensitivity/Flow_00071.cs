namespace FlowBlot.Flows
{
    public class Flow_00071
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            int a = 6;
            int b = 5;

            if (a >= b)            
            {
                input = System.String.Empty;
            }

            /*FLOW:Flow_00071 - A flow-sensitivity vs path-sensitivity FP taint propagation:codethreat.flowblot.benchmark:4:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(input);
        }
    }
}
