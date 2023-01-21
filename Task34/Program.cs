/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/ 

int[] FullArray(int length, int start, int end)
{
    int[] array = new int [length];
    for(int i = 0; i<length; i++)
    {
        array[i] = new Random().Next(start, end+1);
    }
    return array;
}
int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
int QuantityEvenNumbers(int[] array)
{
int count = 0;
    for(int i = 0; i < array.Length; i++)
{
    if(array[i]%2==0)
    {
        count++;
    }
}
return count;
}
void PrintArray(int[]array)
{
    Console.Write("[");
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write(array[i]);
        if(i<array.Length-1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
int number= getUserData("Введите количество элемнтов массива");
int[] array = FullArray(number, 100, 999);
PrintArray(array);
int count = QuantityEvenNumbers(array);
Console.WriteLine($"Количество чентых чисел в массиве равно {count}");

