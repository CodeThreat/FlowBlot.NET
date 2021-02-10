namespace FlowBlot
{
    public class Flow_00064
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            string [] anArray = new string []
            {
                input,
                System.String.Empty,
                System.String.Empty
            };

            /*FLOW:Flow_00064 - An inline Array definition taint propagation:codethreat.flowblot.benchmark:5:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(anArray[0]);
        }
    }
}
