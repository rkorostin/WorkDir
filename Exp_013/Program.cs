// Разбор какие методы бывают. В целом их 4 группы

// Группа 1. Методы, которые ничего не принимают и ничего не возвращают
void Method1()
{
    Console.WriteLine("@rkorostin");
}
Method1(); // Вызов метода

// Группа 2. Методы, которые ничего не возвращают, но могут принимать какие-то аргументы
void Method2(string msg) // Метод Method2 принимает аргумент string msg
{
    Console.WriteLine(msg);
}
Method2("Сообщение 1");
Method2(msg: "Сообщение 2");

void Method21(string msg, int count) // Метод Method21 принимает два аргумента:
                                     // string msg и int count
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Сообщение 3", 4);

// Группа 3. Методы, которые что-то возвращают, но ничего не принимают

int Method3() // Если метод что-то возвращает, то первым делом надо указать 
              // какой тип данных будет возвращаться
{
    return DateTime.Now.Year; // Обязательно return чего то, например, какой год
}
int year = Method3();
Console.WriteLine(year);

// Группа 4. Методы, которые что-то возвращают, и что-то принимают
string Method4(int count, string text) // Метод Method4 возвращает тип string, а на
// входе принимает два аргумента - int count и string text
// Например, будем выводить text count раз
{
    int i = 0;
    string result = String.Empty; // Создаём переменную result, в которой 
    // сейчас пустота, т.е. ничего нет (String.Empty)
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(4, "текст ");
Console.WriteLine(res);