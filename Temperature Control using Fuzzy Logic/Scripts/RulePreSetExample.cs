using System;

namespace Temperature_Control_using_Fuzzy_Logic
{
    class RulePreSetExample
    {
        internal int[] OnGetRules(bool showDetails = false)
        {
            int[] hold = new int[] { 2, 1, 0, 2, 1, 0, 1, 0, 0 };

            if (showDetails)
                for(int i = 0; i < hold.Length; i++)
                    Console.WriteLine( $"{(Output)hold[i]}");

            Console.WriteLine("");
            return hold;
        }
    }
}
