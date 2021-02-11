using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00033
    {
        public void Run()
        {

            string input1 = System.String.Empty;

            DataSource ds1 = new DataSource(input1);

            string input2 = FlowBlot.Model.Framework.Source();

            DataSource ds2 = new DataSource(input2);

            string output1 = ds1.getUrl();

            string output2 = ds2.getUrl();

            /*FLOW:Flow_00033 - A context-sensitive points-to analysis taint propagation:codethreat.flowblot.benchmark:12:FIND_ISSUE:1:
            *STEP_PATH:ABC
            */
            FlowBlot.Model.Framework.Sink(output2);
        }
    }
}
