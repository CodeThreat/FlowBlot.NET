namespace FlowBlot.Flows
{
    public class Flow_00080
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();
            RunMe(arg: input, one: string.Empty);
        }

        private void RunMe(string one, string arg)
        {

            /*FLOW:Flow_00080 - A named argument method call:codethreat.flowblot.benchmark:5:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(arg);
        }
    }
}
