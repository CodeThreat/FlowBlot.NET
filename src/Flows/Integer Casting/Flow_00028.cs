namespace FlowBlot.Flows
{
    public class Flow_00028
    {
        // maybe not string injection, but still with a low TrustLevel 
        // for example, same with the Process.Start arguments parameter

        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            int output = System.Int32.Parse(input);

            /*FLOW:Flow_00028 - A integer cast taint propagation:codethreat.flowblot.benchmark:7:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(output.ToString());
        }
    }
}
