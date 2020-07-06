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

            System.Diagnostics.Process.Start(input);
        }

    }
}
