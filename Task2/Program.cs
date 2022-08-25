// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите числo ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int [number];
FillArray(array);
PrintArray(array);
int summ = 0;

for (int i = 0; i < array.Length; i+=2)
    summ = summ + array[i];

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1,100);
        }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
}

Console.WriteLine($"-> {summ}");