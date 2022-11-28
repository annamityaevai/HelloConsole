Console.Write("Enter username: ");
string username = Console.ReadLine();

if(username.ToLower() == "anna")
{
    Console.WriteLine("Yay! It's Anna!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}