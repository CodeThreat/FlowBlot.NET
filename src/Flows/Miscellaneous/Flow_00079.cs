namespace FlowBlot.Flows
{
    public class Flow_00079
    {
        public const string ID = "00079";
        public const string Description = "A wrapper based intriguing hybrid taint flow";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();


            using (var process = new System.Diagnostics.Process())
            {
                process.StartInfo.RedirectStandardInput = true;
                process.Start();
                using (System.IO.StreamWriter writer = process.StandardInput)
                {

                    /*FLOW:Flow_00079 - A wrapper based intriguing hybrid taint flow:OS Command Injection:0+:FIND_ISSUE:1:
                     *STEP_PATH:ABC
                     */
                    writer.WriteLine(input);
                }
            }
        }
    }
}
