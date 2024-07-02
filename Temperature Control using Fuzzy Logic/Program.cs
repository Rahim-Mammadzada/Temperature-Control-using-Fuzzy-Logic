using System;

namespace Temperature_Control_using_Fuzzy_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            RulePreSetExample ruleExample = new RulePreSetExample();
            FuzzyLogic fuzzyLogic = new FuzzyLogic();

            fuzzyLogic.OnInitizlie(66, 35, ruleExample.OnGetRules());
            fuzzyLogic.OnStart();
        }
    }

    public enum Output { Low = 0, Medium = 1, High = 2 }
}
