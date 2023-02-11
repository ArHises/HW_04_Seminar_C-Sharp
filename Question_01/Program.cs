// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void Print(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] FillBenary(int n)
{
    int[] binnary = new int[n];
    Random ran = new Random();
    for (int i = 0; i < binnary.GetLength(0); i++)
    {
        binnary[i] = ran.Next(0,2);// fill 0 or 1
    }
    return binnary;
}
int[] array = FillBenary(8);
Print(array);
