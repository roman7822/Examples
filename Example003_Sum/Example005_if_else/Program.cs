Console.Write("Введите имя пользователя:  ");
string username = Console.ReadLine();

if(username.ToLower() == "маргарита")
{
    Console.WriteLine("Привет, Любимая");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}