Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "lika")
{
    Console.WriteLine("WOW it's LIKA!!!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}