// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных 
Console.WriteLine("Введите числo ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int [number];
FillArray(array);
PrintArray(array);
int count = 0;

for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
count++;

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine($"-> {count}");