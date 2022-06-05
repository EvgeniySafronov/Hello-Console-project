Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАШАААА!");
}
else 
{ 
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}