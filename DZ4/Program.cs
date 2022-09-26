/* Задача 25

int A = Prompt("Введите A:");
int B = Prompt("Введите B:");
Console.WriteLine(Math.Pow(A,B));

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}
*/
/*Задача 27
Console.WriteLine("Введите число:");
int s = Convert.ToInt32(Console.ReadLine());
int sum = Summa(s);
Console.WriteLine(sum);

int Summa(int num)
{
    int sum = 0;
    for (;num > 0;num /= 10)
    {
        sum+=num % 10;
    }
    return sum;
}
*/
//Задача 29
int size = 8;
int[] array = new int[size];
PrArray(array);
Console.WriteLine("[{0}]",string.Join(",",array));

void PrArray(int[] array)
{
    for (int i = 0;i<array.Length;i++)
       array[i] = new Random().Next(0,100);
}

