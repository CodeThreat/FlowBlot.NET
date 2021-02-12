
namespace FlowBlot.Flows
{
    public class Flow_00018
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            string output = Nest(Nest(Nest(Nest(Nest(Nest(Nest(input)))))));

            /*FLOW:Flow_00018 - A deep nested call taint propagation:codethreat.flowblot.benchmark:16:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(output);
        }

        public string Nest(string input)
        {
            return input;
        }

    }
}
