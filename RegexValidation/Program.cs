// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using RegexValidation;

Console.WriteLine("----- Regex User Validation -----\n");

RegexOps pattern = new RegexOps();

Console.Write("Enter Mobile Number of the User :- ");
string User_MobNo = Console.ReadLine();
if (pattern.ValidateUserName(User_MobNo))
{
    Console.WriteLine("\n>> User Mobile Number format is valid....");
}
else
{
    Console.WriteLine("\n>> User Mobile Number format is Invalid....");
}