// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] FillThreeDigit(int n)
{
    int[] array = new int[n];
    Random ran = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = ran.Next(100,1000);// fill 100 to 999
    }
    return array;
}
void Print(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void EvenNumber(int[] array){
    int counterEven = 0;
    int counterOdd = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(array[i] %2 == 0) counterEven++;
        else counterOdd++;
    }
    Console.WriteLine($"Even counter: {counterEven} | Odd counter: {counterOdd}");
}
Console.WriteLine("Enter the length of the array: ");
int length = int.Parse(Console.ReadLine());
int[] array = FillThreeDigit(length);
Print(array);
EvenNumber(array);