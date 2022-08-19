int GetSum (int number)
{
    int sum = 0;
    
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine() ?? "0");
num = Math.Abs(num);
Console.WriteLine($"Sum of the digits in entered number = {GetSum(num)}");