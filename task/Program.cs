using System.Linq.Expressions;

string[] GetNewArray(int count, string [] text)
{
    string[] newArray = new string[count];
    int index = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= 3)
        {
            newArray[index] = text[i];
            index++;
        }
    }
    return newArray;
}

void CalculatinNumberMatchingWords(string [] text, out int count)
{
    count = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= 3)
            count++;
    }
}

string [] text = {"Роман", "Ян", "Ира", "Анастасия", "Оля", "Константин"};
CalculatinNumberMatchingWords(text, out int count);
string [] textNew = GetNewArray(count, text);