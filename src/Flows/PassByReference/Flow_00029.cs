namespace FlowBlot.Flows
{
    public class Flow_00029
    {
        public void Run()
        {
            string input = System.String.Empty;

            Pass(ref input);

            /*FLOW:Flow_00029 - A ref pass by reference taint propagation:codethreat.flowblot.benchmark:5:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(input);
        }

        public void Pass(ref string input)
        {
            input = FlowBlot.Model.Framework.Source();
        }
    }
}
