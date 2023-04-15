Console.WriteLine("Please enter the length of the classroom.");

string userinput = Console.ReadLine();

int length = int.Parse(userinput);

Console.WriteLine();

Console.WriteLine("Please enter the width of the classroom.");

userinput = Console.ReadLine();

int width = int.Parse(userinput);

int perimiter = 2 * (length + width);

Console.WriteLine();


int area = length * width;

Console.WriteLine("The perimiter of the classroom is " + perimiter + ".");
Console.WriteLine();

Console.WriteLine("The area of the classroom is " + area + ".");
Console.WriteLine();


if (area <= 250)
{
    Console.WriteLine("Room is small");
}

else if (area > 250 && area < 650)
{
    Console.WriteLine("Room is medium");
}

else if (area >= 650)
{
    Console.WriteLine("Room is large");
}