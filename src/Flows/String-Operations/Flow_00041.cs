namespace FlowBlot.Flows
{
    public class Flow_00041
    {
        public void Run()
        {
            string input = "Name: {0}";
            string output = System.String.Format(input, System.Console.ReadLine());

            /*CTSECISSUE:Flow_00041 - A string format taint propagation:codethreat.flowblot.benchmark:3:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(output);
        }

    }
}
