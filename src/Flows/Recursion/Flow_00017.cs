
namespace FlowBlot.Flows
{
    public class Flow_00017
    {
        public void Run()
        {
            string input = Sprinkle(System.Console.ReadLine());

            /*FLOW:Flow_00017 - A recursive taint propagation:codethreat.flowblot.benchmark:3:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(input);
        }

        public string Sprinkle(string input)
        {
            string output = input + "s";

            if (output.Length < 1000)
            {
                output = Sprinkle(output);
            }

            return output;
        }

    }
}
