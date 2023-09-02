using System.Linq.Expressions;
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