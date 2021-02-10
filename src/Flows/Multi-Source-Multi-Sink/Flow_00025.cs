namespace FlowBlot.Flows
{
    public class Flow_00025
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            /*FLOW:Flow_00025 - A multi sink taint propagation:codethreat.flowblot.benchmark:3:FIND_ISSUE:1:
             */
            FlowBlot.Model.Framework.Sink(input);

            new Flow_00026().Run(input);
        }
    }
}
