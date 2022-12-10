// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.

double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите элементы массива");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}
double MinSearch(double[] array)
{
    double min = array[0];
    foreach (double el in array)
    {
        if (el < min) min = el;
    }
    return min;
}

double MaxSearch(double[] array)
{
    double max = array[0];
    foreach (double el in array)
    {
        if (max < el) max = el;
    }
    return max;
}

void PrintArray(double[] array)
{
    foreach (double el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(size);
PrintArray(array);
Console.WriteLine("Максимальный элемент массива: " + MaxSearch(array));
Console.WriteLine("Минимальный элемент массива: " + MinSearch(array));
Console.WriteLine($"Разность между минимальным и максимальным элементами массива равна: {MaxSearch(array) - MinSearch(array)}");

