namespace FlowBlot.Flows
{
    public class Flow_00014
    {
        public void Run()
        {
            int x = 1;
            int y = 2;

            string input2 = System.String.Empty;
            string input = System.String.Empty;

            if(x > y)
            {
                input = "Default";
            }
            else
            {
                input = FlowBlot.Model.Framework.Source();
            }

            input2 = input;

            /*FLOW:Flow_00014 - A complex if taint propagation:codethreat.flowblot.benchmark:5:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(input2);
        }

    }
}
