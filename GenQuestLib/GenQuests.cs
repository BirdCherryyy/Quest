namespace QUEST.GenQuestLib;
public class GenQuests
{

    public void GenOneQuest(string[,] Quest)//Генерирует 1 вопрос и 4 ответа
    {
        string[] MemoryStr = new string[4];
        Random rnd = new Random(); 
        int rndQuest = rnd.Next(0, Quest.Length);
        int rndAnswer = rnd.Next(0, MemoryStr.Length);

        for (int i = 0; i < MemoryStr.Length; i++)//Рандомим ответы
        {
            rndAnswer = rnd.Next(0, MemoryStr.Length);
            MemoryStr[i] = GetOneAnswer(Quest, rndQuest);
        }

        rndAnswer = rnd.Next(0, MemoryStr.Length);
        MemoryStr[rndAnswer] = Quest[rndQuest,1]; //Засовываем правлиьный ответ

        Console.WriteLine("Вопрос: ", Quest[rndQuest,0]);
        Console.WriteLine("\nВычберите правильный вариант:\n");
        for (int i = 0; i < MemoryStr.Length; i++)
        {
            Console.WriteLine("{0}) {1}", ++i, MemoryStr);
        }
        int MyAnswer = Convert.ToInt32(Console.ReadLine());

        if (Check(Quest[MyAnswer-1,0],Quest[rndQuest,0]))
        {
            Console.WriteLine("Врено!");
        }
        else Console.WriteLine("Не верно");
    }

    public string GetOneAnswer(string[,] Quest, int notThis)//Выдает любой ответ кроме notThis
    {
        Random rnd = new Random(); int rndGet = rnd.Next(0, Quest.Length);
        while (true)
        {
            if (rndGet == notThis) 
            {
                rndGet = rnd.Next(0, Quest.Length);
            }
        else return Quest[rndGet, 0]; 
        }
    }
    public bool Check(string str1, string str2)
    {
        if (str1 == str2) return true;
        else return false;
    }
}
