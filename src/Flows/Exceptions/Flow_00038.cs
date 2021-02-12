namespace FlowBlot.Flows
{
    public class Flow_00038
    {
        public void Run()
        {
            try
            {
                string input = FlowBlot.Model.Framework.Source();

                ThrowThat(input);
            }
            catch(System.Exception e)
            {
              /*FLOW:Flow_00038 - An exception handler taint propagation:codethreat.flowblot.benchmark:0+:FIND_ISSUE:1:
              *STEP_PATH:ABC
              */
                FlowBlot.Model.Framework.Sink(e.Message);
            }
        }

        public void ThrowThat(string i)
        {

            throw new System.Exception(i);
        }

    }
}
