// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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
        Console.Write($"{array[i]} | ");
    }
    Console.WriteLine();
}
void ProductOfPairs(int[] array){
    for (int i = 0; i < array.Length/2; i++)
    {
        Console.WriteLine($"{array[i]} * {array[array.Length - 1 - i]} = {array[array.Length - 1 - i] * array[i]}");
    }
}
Console.WriteLine("Enter the length of the array: ");
int length = int.Parse(Console.ReadLine());
int[] array = FillThreeDigit(length);
Print(array);
ProductOfPairs(array);