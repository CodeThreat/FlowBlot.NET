namespace FlowBlot.Flows
{
    public class Flow_00040
    {
        public void Run()
        {
            float x = 5.0f;
            if(x > 6.5f)
            {
                string input = System.String.Empty;
            }
        }

        private void NeverCalled()
        {
            string input = FlowBlot.Model.Framework.Source();

            /*FLOW:Flow_00040 - An unreachable taint flow:codethreat.flowblot.benchmark:3:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(input);
        }
    }
}
