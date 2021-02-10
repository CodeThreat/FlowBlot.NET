namespace FlowBlot.Flows
{
    public class Flow_00031
    {
        public static string medium = System.String.Empty;

        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            medium = input;

            /*FLOW:Flow_00031 - A static variable taint propagation:codethreat.flowblot.benchmark:5:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(medium);
        }
    }
}
