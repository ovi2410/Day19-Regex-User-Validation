// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using RegexValidation;

Console.WriteLine("----- Regex User Validation -----\n");

RegexOps pattern = new RegexOps();

Console.Write("Enter the First Name of the User :- ");
string username = Console.ReadLine();
if (pattern.ValidateUserName(username))
{
    Console.WriteLine("\n>> UserName format is Valid....");
}
else
{
    Console.WriteLine("\n>> UserName format is Invalid....");
}