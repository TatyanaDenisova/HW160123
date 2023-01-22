/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
double[] FullArray(int length, int start, int end)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}
int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
double ResultNumber(double[] array)
{
    double max = array[1];
    double min = array[1];
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
        result = max - min;
    }
    return result;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
int number = getUserData("Введите количество элемнтов массива");
double[] array = FullArray(number, 0, 20);
PrintArray(array);
double result = ResultNumber(array);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {result}");