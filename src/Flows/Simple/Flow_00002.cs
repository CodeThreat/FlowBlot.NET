namespace FlowBlot
{
    public class Flow_00002
    {
        public void Run()
        {
            /*FLOW:Flow_00002 - A nested method call source to sink taint propagation:codethreat.flowblot.benchmark:1:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(FlowBlot.Model.Framework.Source());
        }
    }
}
