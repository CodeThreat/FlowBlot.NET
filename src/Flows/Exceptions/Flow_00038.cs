namespace FlowBlot.Flows
{
    public class Flow_00038
    {
        public void Run()
        {
            try
            {
                ThrowThat();
            }
            catch(System.Exception e)
            {
              /*FLOW:Flow_00038 - An exception handler taint propagation:codethreat.flowblot.benchmark:0+:FIND_ISSUE:1:
              *STEP_PATH:ABC
              */
                FlowBlot.Model.Framework.Sink(e.Message);
            }
        }

        public void ThrowThat()
        {
            string input = FlowBlot.Model.Framework.Source();

            throw new System.Exception(input);
        }

    }
}
