// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your age:");
int h = Int32.Parse("1999");
h = 2022 - h;
Console.WriteLine(h);
int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack

if(userAge > 13)
{

    Console.WriteLine("Welcome to Instagram!");
}
else if(userAge == 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else//if (userAge < 13)
{
    Console.WriteLine("You are too young to use Instagram.");
}