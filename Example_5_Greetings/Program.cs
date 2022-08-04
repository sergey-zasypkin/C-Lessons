Console.Write("Type your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Masha!!! My Darling!!! How are you doing?");    
}
else
{
    Console.Write("Hi, ");
    Console.Write(username);
    Console.WriteLine("!");
}