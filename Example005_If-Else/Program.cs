Console.Write("Write user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Have a nice day, Masha!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}