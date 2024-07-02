using System;

namespace Temperature_Control_using_Fuzzy_Logic
{
    class MemberItem
    {
        internal int spread = 0;
        internal float midPoint = 0;
        internal float weight = 0;
        private string nameMember = "";
        private string nameParameter = "";

        internal MemberItem(int midPoint, int spread, string nameMember, string nameParameter)
        {
            this.midPoint = midPoint;
            this.spread = spread;
            this.nameMember = nameMember;
            this.nameParameter = nameParameter;
        }

        internal void OnCalculateWeight(float temperature)
        {
            if (temperature < midPoint-spread) 
                weight = 0; 
            else if (temperature > midPoint+spread)
                weight = 0; 
            else if (temperature <= midPoint)
                weight = (temperature - (midPoint - spread)) / spread;
            else
                weight = (midPoint + spread - temperature) / spread;
        }

        internal string OnGetName() => $"{nameParameter} {nameMember}";

        internal void OnDebug() => Console.WriteLine($" -{nameMember}: {weight}");
    }
}
