namespace FlowBlot.Flows
{
    public class Flow_00015
    {
        public void Run()
        {
            int x = 1;
            int y = 2;

            string input2 = System.String.Empty;
            string input = System.String.Empty;

            if(x > y)
            {
                input = FlowBlot.Model.Framework.Source();
            }
            else
            {
                input = "Default";
            }

            input2 = input;

            /*FLOW:Flow_00015 - A complex if FP taint propagation:codethreat.flowblot.benchmark:6:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(input2);
        }

    }
}
