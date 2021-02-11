namespace FlowBlot.Flows
{
    public class Flow_00044
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();
            Method1(input);
        }

        public void Method1(string input)
        {            
            if (5 > 1)
            {
                Method2(input);
            }

            /*FLOW:Flow_00044 - A source to sink complex trace order:codethreat.flowblot.benchmark:12:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(input);
        }

        public void Method2(string input)
        {
            input = input.Substring(5);
        }
    }
}
