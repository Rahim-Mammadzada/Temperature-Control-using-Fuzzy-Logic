using System;

namespace Temperature_Control_using_Fuzzy_Logic
{
    class FuzzyLogic
    {
        int pressure = 0;
        int temperature = 0;
        int[] mappedWeights = new int[] { };

        internal void OnInitizlie(int temperature, int pressure, int[] rules)
        {
            this.mappedWeights = rules;
            this.pressure = pressure;
            this.temperature = temperature;
        }

        internal void OnStart()
        {
            Console.Write($"Temperature: {temperature} Celcius\n");

            MemberList membersTemperature = new MemberList(new MemberItem[]
            {
                new MemberItem(40, 30, "Cold", "Temperature"),
                new MemberItem(80, 30, "Normal", "Temperature"),
                new MemberItem(120, 30, "Hot", "Temperature")
            });

            membersTemperature.OnCalculateWeights(temperature);
            membersTemperature.OnDebugWeights();

            Console.Write($"Pressure: {pressure} Bar\n");
            MemberList memberPressure = new MemberList(new MemberItem[]
            {
                new MemberItem(0, 40, "Low", "Pressure"),
                new MemberItem(50, 40, "Medium", "Pressure"),
                new MemberItem(100, 40, "High", "Pressure")
            });

            memberPressure.OnCalculateWeights(pressure);
            memberPressure.OnDebugWeights();

            MemberList memberOutput = new MemberList(new MemberItem[]
            {
                new MemberItem(0, 50, "Low", "Heater Intensity"),
                new MemberItem(50, 50, "Medium", "Heater Intensity"),
                new MemberItem(100, 50, "High", "Heater Intensity")
            });

            RuleList ruleList = new RuleList(memberPressure, membersTemperature, memberOutput, mappedWeights);
            ruleList.OnDebug();

            Console.Write("\nOutput Weights\n");
            memberOutput.OnCalculateWeights(ruleList.ruleItems, mappedWeights);
            memberOutput.OnDebugWeights();

            Defuzzyfier defuzzyfier = new Defuzzyfier();
            Console.Write($"Output: {defuzzyfier.OnSugenoMethod(memberOutput)}%\n");
        }
    }
}
