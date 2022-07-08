// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using RegexValidation;

Console.WriteLine("----- Regex User Validation -----\n");

RegexOps pattern = new RegexOps();

Console.Write("Enter Password of the User :- ");
string User_Pass = Console.ReadLine();
if (pattern.ValidateUserName(User_Pass))
{
    Console.WriteLine("\n>> User Password format is valid....");
}
else
{
    Console.WriteLine("\n>> User Password format is Invalid....");
}