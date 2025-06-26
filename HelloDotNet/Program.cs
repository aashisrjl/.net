// See https://aka.ms/new-console-template for more information
//switch 
int i=0;
while(i<=10){
Console.WriteLine("\n Enter your name:");
string input = Console.ReadLine();
switch (input)
{
    case "kushal":
        Console.WriteLine("you are kusal.");
        break;
    case "kedar":
        Console.WriteLine("You are a older than us.");
        break;
    case "rojan":
        Console.WriteLine("You are father of dogs and fat.");
        break;
    default:
        Console.WriteLine("You are a senior citizen.");
        break;
}
i++;
Console.WriteLine("Do you want to continue? (yes/no)");
string continueInput = Console.ReadLine();
if (continueInput.ToLower() = "no")
{
    break;

}
}