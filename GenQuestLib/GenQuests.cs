namespace QUEST.GenQuestLib;
using QUEST;
using System;
public class GenQuests
{

    public void GenOneQuest(string[] Quests, string[] Answers)//Генерирует 1 вопрос и 4 ответа
    {
        string[] MemoryStr = new string[4];//Память для 4 ответов 1 из которых будет правильным
        int trueQA = 999;// Переменная с правильным индексом ответа

        Random rnd = new Random(); // Определяем вопрос и ответ на него
        trueQA = rnd.Next(0, Quests.Length-1);

        Rnd4Answer(MemoryStr, Answers, trueQA); //Рандомим 4 уникальных ответа кроме trueQA
        RndTrueAnswer(MemoryStr, Answers, trueQA);//Пихаем в память правильный ответ
        OutMessage(Quests, MemoryStr, trueQA);//вывод сообщения о вопросе и ответах
        int MyAnswer = Convert.ToInt32(Console.ReadLine());//Ввод с клавиатуры
        OutMessage2(CheckAnswer(Answers, MemoryStr, MyAnswer, trueQA));
    }

    private void OutMessage2(bool Answer)
    {
        if (Answer==true)
        {
            Console.WriteLine("Врено!");
        }
        else Console.WriteLine("Не верно");
    }
    private bool CheckAnswer(string[] Answers, string[] MemoryStr, int MyAnswer, int trueQA)//Проверка выбранного ответа и правильного ответа
    {
        return Check(Answers[trueQA], MemoryStr[MyAnswer-1]);
    }
    private void OutMessage(string[] Quests, string[] MemoryStr, int trueQA)//вывод сообщения о вопросе и ответах
    {
        Console.WriteLine("Вопрос: {0}", Quests[trueQA]);
        Console.WriteLine("\nВыберите правильный вариант:\n");
        for (int i = 0; i < MemoryStr.Length; i++)
        {
            Console.WriteLine("{0}) {1}", i+1, MemoryStr[i]);
        }
    }
    private string GetOneAnswer(string[] Answer, int notThis)//Выдает любой ответ кроме notThis
    {
        Random rnd = new Random(); int rndGet = rnd.Next(0, Answer.Length);
        while (true)
        {
            if (rndGet == notThis) 
            {
                rndGet = rnd.Next(0, Answer.Length);
            }
        else return Answer[rndGet]; 
        }
    }
    private bool Check(string str1, string str2)//Проверка на правильность выбранного ответа
    {
        if (str1 == str2) return true;
        else return false;
    }
    private void Rnd4Answer(string[] MemoryStr, string[] Answer, int notThis)//Рандомим 4 уникальных ответа
    {    
        for (int i = 0; i < MemoryStr.Length; i++)//Рандомим ответы
        {
            do //Пока есть совпадение(вопроса в памяти с каким-либо вопросом в массиве) - рандомить вопрос
            {
                MemoryStr[i] = GetOneAnswer(Answer, notThis);
            } while (CheckDuplication(MemoryStr[i], MemoryStr));
        }
    }
    private bool CheckDuplication(string str, string[] arrStr)//Проверка есть ли совпадение строки со строками в массиве (false - есть совпадение, true - нету совпадение)
    {
        for (int i = 0; i < arrStr.Length; i++)
        {
            if (str == arrStr[i])
            {
                return false;
            }
        }
        return true;
    }
    private void RndTrueAnswer(string[] MemoryStr, string[] Answers, int trueQA)//Рандомим положение правильного ответа
        {
            Random rnd = new Random(); // Рандомим число для положения
            int rndInt = rnd.Next(0, MemoryStr.Length-1);
            MemoryStr[rndInt] = Answers[trueQA];
        }
}   
