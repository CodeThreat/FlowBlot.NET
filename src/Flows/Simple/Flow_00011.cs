namespace FlowBlot.Flows
{
    public class Flow_00011
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();
            string colored = Color(input);

            /*FLOW:Flow_00011 - A return value taint propagation:codethreat.flowblot.benchmark:6:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(colored);
        }

        public string Color(string input)
        {
            return input;
        }
    }
}
