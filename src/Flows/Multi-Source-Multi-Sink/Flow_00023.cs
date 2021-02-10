namespace FlowBlot.Flows
{
    public class Flow_00023
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            /*FLOW:Flow_00023 - A multi source taint propagation:codethreat.flowblot.benchmark:0:NONE:0:
             *STEP_PATH:ABC
             */
            new Flow_00024().Run(input);
        }
    }
}
