namespace Temperature_Control_using_Fuzzy_Logic
{
    class Defuzzyfier
    {
        internal float OnSugenoMethod(MemberList pass)
        {
            float sum = 0;
            float weights = 0;

            for (int i = 0; i < pass.members.Length; i++)
            {
                sum += pass.members[i].midPoint * pass.members[i].weight;
                weights += pass.members[i].weight;
            }

            return sum/weights;
        }
    }
}
