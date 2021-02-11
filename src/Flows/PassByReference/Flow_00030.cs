namespace FlowBlot.Flows
{
    public class Flow_00030
    {
        public void Run()
        {
            string input;

            Pass(out input);


            /*FLOW:Flow_00030 - An out pass by reference taint propagation:codethreat.flowblot.benchmark:5:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(input);
        }

        public void Pass(out string input)
        {
            input = FlowBlot.Model.Framework.Source();
        }
    }
}
