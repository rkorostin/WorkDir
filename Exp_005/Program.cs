Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
//if(username == "роман") // На точное совпадение
if (username.ToLower() == "роман")
{
    Console.WriteLine("Здорово, Роман!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}