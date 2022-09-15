namespace QUEST.MyQuestLib;
public class MyQuest
{
    string[,] Quests;
    public MyQuest()
    {
        Quests = new string[4,2] {{ "Кто чирикает?","Воробей"},{"Кто лает?","Собака"},{"Кто чирикает?","Воробей"},{"Кто хрюкает?","Свинья"}};
       //Quests.add(new string[,] {{ "Кто чирикает?"},{"Воробей"}});
       //Quests.add(new string[,] {{ "Кто лает?"},{"Собака"}});
       //Quests.add(new string[,] {{ "Кто хрюкает?"},{"Свинья"}});
    }

   // public void Add(string quest, string answer){
   //     Quests = new string[,] {{quest},{answer}};
   // }
}
