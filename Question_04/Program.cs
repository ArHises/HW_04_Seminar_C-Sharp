// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] FillThreeDigit(int n)
{
    int[] array = new int[n];
    Random ran = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = ran.Next(0,10);// fill 0 to 9
    }
    return array;
}
void Print(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"Position {i} = {array[i]} | ");
    }
    Console.WriteLine();
}
int SumOddNumbers(int[] array){
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
Console.WriteLine("Enter the length of the array: ");
int length = int.Parse(Console.ReadLine());
int[] array = FillThreeDigit(length);
Print(array);
Console.WriteLine("Sum = " + SumOddNumbers(array));
