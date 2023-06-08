//Math >= 90: Biology >=90: Chemistry >=90;


int math, biology, chemistry;

Console.WriteLine("Enter your math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());


if (math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congratulations! You've been accepted to Hogwarts School of Shenanigans and Medicine");
}
else
{
    Console.WriteLine("Your application cannot be approved. Not sorry though. Go cry somewhere else.");
}
