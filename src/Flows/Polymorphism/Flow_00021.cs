using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00021
    {
        public const string ID = "00021"; 
        public const string Description = "A polymorphic taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            Machine machine = new Robot();
            Robot robot = (Robot)machine;
            robot.name = System.Console.ReadLine();

            string input = robot.name;

            /*FLOW:Flow_00021 - A polymorphic taint propagation:OS Command Injection:5:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(input);
        }

    }
}
