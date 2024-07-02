using System;

namespace Temperature_Control_using_Fuzzy_Logic
{
    class RuleItem
    {
        internal float weight = 0;
        private string condition_1 = "";
        private string condition_2 = "";
        private string resulting = "";

        internal void OnSet(float weight, string condition_1, string condition_2, string resulting)
        {
            this.weight = weight;
            this.condition_1 = condition_1;
            this.condition_2 = condition_2;
            this.resulting = resulting;
        }

        internal void OnDebug()
        {
            if (weight == 0) return;
            Console.WriteLine($" -{condition_1} & {condition_2} gives: {resulting} {weight}");
        }
    }
}
