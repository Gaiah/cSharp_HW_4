Console.WriteLine("Enter a number: ");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("And its power: ");
int numB = int.Parse(Console.ReadLine() ?? "0");
numB = Math.Abs(numB);
int firstA = numA;
int i = 0;

// Это решение может и не короткое, но работает даже с 0, в отличие от метода Math.Pow

//Console.WriteLine($"{numA} raised to a power {numB} = {Math.Pow(numA, numB)}");

if (numA == 0)
{
    Console.WriteLine($"{firstA} raised to a power {numB} = {numA}");    
}

else 
{
    while (i < numB) 
    {
        numA *= firstA;
        i++;
    }
    numA /= firstA;
    Console.WriteLine($"{firstA} raised to a power {numB} = {numA}");
}