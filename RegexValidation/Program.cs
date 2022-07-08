// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using RegexValidation;

Console.WriteLine("----- Regex User Validation -----\n");

RegexOps pattern = new RegexOps();

//Console.Write("Enter Password of the User :- ");
//string Sample_Mail_ID = Console.ReadLine();

if (pattern.ValidateUserName("abc@yahoo.com"))
{
    Console.WriteLine("Test case 1:");
    Console.WriteLine("\n>> Sample Email_ID format is valid....");
}
else
{
    Console.WriteLine("Test case 1:");
    Console.WriteLine("\n>> Sample Email_ID format is Invalid....");
}

//---------------------------------------------------------------------------------

if (pattern.ValidateUserName("abc-100@yahoo.com"))
{
    Console.WriteLine("Test case 1:");
    Console.WriteLine("\n>> Sample Email_ID format is valid....");
}
else
{
    Console.WriteLine("Test case 1:");
    Console.WriteLine("\n>> Sample Email_ID format is Invalid....");
}

//---------------------------------------------------------------------------------

if (pattern.ValidateUserName("abc-100@yahoo.com"))
{
    Console.WriteLine("\nTest case 2:");
    Console.WriteLine("\n>> Sample Email_ID format is valid....");
}
else
{
    Console.WriteLine("\nTest case 2:");
    Console.WriteLine("\n>> Sample Email_ID format is Invalid....");
}

//---------------------------------------------------------------------------------

if (pattern.ValidateUserName("abc.100@yahoo.com"))
{
    Console.WriteLine("\nTest case 3:");
    Console.WriteLine("\n>> Sample Email_ID format is valid....");
}
else
{
    Console.WriteLine("\nTest case 3:");
    Console.WriteLine("\n>> Sample Email_ID format is Invalid....");
}

//---------------------------------------------------------------------------------

if (pattern.ValidateUserName("abc111@abc.com"))
{
    Console.WriteLine("\nTest case 4:");
    Console.WriteLine("\n>> Sample Email_ID format is valid....");
}
else
{
    Console.WriteLine("\nTest case 4:");
    Console.WriteLine("\n>> Sample Email_ID format is Invalid....");
}

//---------------------------------------------------------------------------------

if (pattern.ValidateUserName("abc-100@abc.net"))
{
    Console.WriteLine("\nTest case 5:");
    Console.WriteLine("\n>> Sample Email_ID format is valid....");
}
else
{
    Console.WriteLine("\nTest case 5:");
    Console.WriteLine("\n>> Sample Email_ID format is Invalid....");
}

//---------------------------------------------------------------------------------

if (pattern.ValidateUserName("abc.100@abc.com.au"))
{
    Console.WriteLine("\nTest case 6:");
    Console.WriteLine("\n>> Sample Email_ID format is valid....");
}
else
{
    Console.WriteLine("\nTest case 6:");
    Console.WriteLine("\n>> Sample Email_ID format is Invalid....");
}

//---------------------------------------------------------------------------------

if (pattern.ValidateUserName("abc@1.com"))
{
    Console.WriteLine("\nTest case 7:");
    Console.WriteLine("\n>> Sample Email_ID format is valid....");
}
else
{
    Console.WriteLine("\nTest case 7:");
    Console.WriteLine("\n>> Sample Email_ID format is Invalid....");
}

//---------------------------------------------------------------------------------

if (pattern.ValidateUserName("abc@gmail.com.com"))
{
    Console.WriteLine("\nTest case 8:");
    Console.WriteLine("\n>> Sample Email_ID format is valid....");
}
else
{
    Console.WriteLine("\nTest case 8:");
    Console.WriteLine("\n>> Sample Email_ID format is Invalid....");
}

//---------------------------------------------------------------------------------

if (pattern.ValidateUserName("abc+100@gmail.com"))
{
    Console.WriteLine("\nTest case 9:");
    Console.WriteLine("\n>> Sample Email_ID format is valid....");
}
else
{
    Console.WriteLine("\nTest case 9:");
    Console.WriteLine("\n>> Sample Email_ID format is Invalid....");
}
