namespace FlowBlot.Flows
{
    public class Flow_00027
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();
            string condition = FlowBlot.Model.Framework.Source();

            switch (condition)
            {
                case "one":
                    input = System.String.Empty;
                    break;
                case "two":
                case "three":
                    break;
                default:
                    break;
            }

            /*FLOW:Flow_00027 - A switch taint propagation:codethreat.flowblot.benchmark:4:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(input);
        }
    }
}
