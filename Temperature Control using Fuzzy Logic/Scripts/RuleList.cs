using System;

namespace Temperature_Control_using_Fuzzy_Logic
{
    class RuleList
    {
        internal RuleItem[] ruleItems;

        internal RuleList(MemberList condition_1, MemberList condition_2, MemberList resulting, int[] indexArray)
        {
            ruleItems = new RuleItem[condition_1.members.Length * condition_2.members.Length];
            for (int i = 0; i < ruleItems.Length; i++)
                ruleItems[i] = new RuleItem();

            int index = 0;

            for (int i = 0; i < condition_1.members.Length; i++)
            {
                for (int j = 0; j < condition_2.members.Length; j++)
                {
                    ruleItems[index].OnSet(Math.Min(condition_1.members[i].weight, condition_2.members[j].weight),
                        $"{condition_1.members[i].OnGetName()}",
                        $"{condition_2.members[j].OnGetName()}",
                        $"{resulting.members[indexArray[index]].OnGetName()}");
                    index++;
                }
            }
        }

        internal void OnDebug()
        {
            Console.WriteLine("Rules:");

            for (int i = 0; i < ruleItems.Length; i++)
            {
                ruleItems[i].OnDebug();
            }
        }
    }
}
