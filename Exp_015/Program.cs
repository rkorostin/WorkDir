/* Дан текст. В тексте нужно все пробелы заменить звездочками
*/

string text = "Пример текста, в котором нужно заменить все пробелы на символ *";

string Replase(string text, char oldValue, char newValue);
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replase(text, ' ', '*');
ConsoleWrite(newText);

