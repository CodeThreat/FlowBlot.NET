namespace FlowBlot.Flows
{
    public class Flow_00039
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            var sb = new System.Text.StringBuilder();

            foreach (char c in input)
            {
                if (c > 69)
                {
                    sb.Append(c);
                }
            }

            /*FLOW:Flow_00039 - A StringBuilder taint propagation:codethreat.flowblot.benchmark:7:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(sb.ToString());
        }

    }
}
