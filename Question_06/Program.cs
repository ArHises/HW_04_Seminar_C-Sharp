// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] FillThreeDigit(int n)
{
    double[] array = new double[n];
    Random ran = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = ran.Next(0,50);// fill 0 to 50
    }
    return array;
}
void Print(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} | ");
    }
    Console.WriteLine();
}
double FindMax(double[] array){
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }
    return max;
}
double FindMin(double[] array){
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }
    return min;
}
double Difference(double max, double min) => max - min;

Console.WriteLine("Enter the length of the array: ");
int length = int.Parse(Console.ReadLine());
double[] array = FillThreeDigit(length);
Print(array);
Console.WriteLine($"{FindMax(array)} - {FindMin(array)} = {Difference(FindMax(array),FindMin(array))}");