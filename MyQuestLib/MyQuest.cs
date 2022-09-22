namespace QUEST.MyQuestLib;
public class MyQuest
{
    public string[] Quests;
    public string[] Answers;
    public MyQuest()//правильный ответ из массива ответов будет соотвестовать индексу в массиве вопросов 
    {
        Quests = new string[] {"Кто чирикает?", "Кто лает?", "Кто каркает?", "Кто хрюкает?", "Кто обитает под землей?", "Полосатая кошка - это..."};
        Answers = new string[] {"Воробей", "Собака", "Ворона", "Свинья", "Крот", "Тигр"};
    }

   // public void Add(string quest, string answer){
   //     Quests = new string[,] {{quest},{answer}};
   // }
}
