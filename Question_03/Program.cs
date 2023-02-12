// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] FillThreeDigit(int n)
{
    int[] array = new int[n];
    Random ran = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = ran.Next(0,200);// fill 100 to 199
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
int FindTenToNinetynine(int[] array){
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] < 100) counter++;
    }
    return counter;
}
int[] array = FillThreeDigit(123);
Print(array);
Console.WriteLine($"Counter of numbers between 10 and 99 is: {FindTenToNinetynine(array)}");

