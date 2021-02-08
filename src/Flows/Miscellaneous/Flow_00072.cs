

using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00072
    {
        public const string ID = "00072";
        public const string Description = "A 3rd-party code taint propagation";
        public const bool IsVulnerable = true; // a step towards soundness. not precise. trust level matters: medium|low

        public void Run()
        {
            string input = System.Console.ReadLine();
            IWeatherService weatherService = WeatherServiceFinder.FetchProvider();
            string passThrough = weatherService.GetWeatherData(input);

            /*FLOW:Flow_00072 - A 3rd-party code taint propagation:OS Command Injection:7:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(passThrough);
        }
    }
}
