Random rand = new Random();
int [] arr = new int [8];
for(int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next();
    Console.Write($" {arr[i]},");
}