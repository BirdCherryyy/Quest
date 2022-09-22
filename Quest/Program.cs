using System;
using QUEST.GenQuestLib;
using QUEST.MyQuestLib;

namespace QUEST.Quest;
internal class Program
{
    private static void Main(string[] args)
    {   
        MyQuest myquest = new MyQuest();
        GenQuests genquests = new GenQuests();
        genquests.GenOneQuest(myquest.Quests, myquest.Answers);
    }
}