using System;

namespace Temperature_Control_using_Fuzzy_Logic
{
    class MemberList
    {
        internal MemberItem[] members;

        internal MemberList(MemberItem[] pass) => members = pass;
        
        internal void OnCalculateWeights(int pass)
        {
            for (int i = 0; i < members.Length; i++)
                members[i].OnCalculateWeight(pass);

            if (pass < members[0].midPoint)
                members[0].weight = 1;
            if (pass > members[members.Length - 1].midPoint)
                members[members.Length - 1].weight = 1;
        }

        internal void OnCalculateWeights(RuleItem[] rules, int[] indexes)
        {
            for (int i = 0; i < rules.Length; i++)
            {
                if (rules[i].weight > members[indexes[i]].weight)
                    members[indexes[i]].weight = rules[i].weight;
            }
        }
        
        internal void OnDebugWeights()
        {
            for (int i = 0; i < members.Length; i++)
                members[i].OnDebug();

            Console.Write("\n");
        }
    }
}