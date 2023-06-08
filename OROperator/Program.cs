//Math >= 90 OR (||) Chemistry >= 90 /OR (||) Biology >=90 

//Math && chemistry >=90 || math && biology >=90 || chemistry && biology >=90


int math, biology, chemistry;

Console.WriteLine("Enter your math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result:");
biology = Int32.Parse(Console.ReadLine());


Console.WriteLine("Enter your chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());


if (math >= 90 && chemistry >= 90 || math >= 90 && biology >= 90 || biology >= 90 || chemistry >= 90)
{
    Console.WriteLine("Congratulations! You've been accepted to Hogwarts School of Shenanigans and Medicine. Here is a pair of scissors and we allow running in the halls.");
}
else
{
    Console.WriteLine("Your application cannot be approved. Not sorry though. Go cry somewhere else.");
}
