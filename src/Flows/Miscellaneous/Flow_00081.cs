namespace FlowBlot.Flows
{
    public class Flow_00081
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();            
            RunMe(string.Empty, input, null, null);
        }

        private void RunMe(string one, params string[] arguments)
        {
            if (arguments != null)
            {
                /*FLOW:Flow_00081 - A dynamic number of arguments method call:codethreat.flowblot.benchmark:5:FIND_ISSUE:1:
                    *STEP_PATH:ABC
                    */
                FlowBlot.Model.Framework.Sink(arguments[0]);
            }
        }
    }
}
