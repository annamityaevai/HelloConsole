﻿// Вид 1
void Method1()
{
    Console.WriteLine("Author ANMI");
}
//Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Text", count: 4);

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);

//Вид 4
//string Method4(int count, string c)
//{
//    int i = 0;
//    string result = String.Empty;
//    while (i < count)
//    {
//        result = result + c;
//        i++;
//    }
//    return result;
//}
//string res = Method4(10, "asdf");
//Console.WriteLine(res);

string Method4(int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string res = Method4(10, "asdf");
//Console.WriteLine(res);

for(int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
//        Console.WriteLine($"{i} x {j} = {i * j}");
    }
//    Console.WriteLine();
}

//===== Работа с текстом
// Дане текст. В тексте нужно все пробелы заменить черточками,
// маленькие буква "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + " Вы так красоречивы. Вы дадите мне чаю?";

// string s = "asd"
//             012
// s[2] //  d

Console.OutputEncoding = System.Text.Encoding.UTF8;
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
