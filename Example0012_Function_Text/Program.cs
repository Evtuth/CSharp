// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
           + "ежели бы вас послали вместо нашего милого Винценгероде,"
           + "вы бы взяли приступом согласие прусского короля."
           + "Вы так красноречивы. Вы дадите мне чаю?";

string Method1(string text, char oldsmb, char newsmb)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0;i < length; i++)
    {
        if(text[i] == oldsmb)
        { 
            result = result + $"{newsmb}";
        }
        else 
        {
            result = result + $"{text[i]}";
        }
    }
    return result;
}
string NewText = Method1(text,' ', '|');
Console.WriteLine(NewText);
Console.WriteLine();
NewText = Method1(NewText,'к', 'К');
Console.WriteLine(NewText);
Console.WriteLine();
NewText = Method1(NewText,'С', 'с');
Console.WriteLine(NewText);
Console.WriteLine();
