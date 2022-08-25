// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

Console.WriteLine("Введите числo ");
double number = Convert.ToInt32(Console.ReadLine());
double[] array = new double [number];
double difference = 0;
double max = 1;
double min = 1;
FillArray(array);
PrintArray(array);

for (double i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

void FillArray(double[] array)
{
    for(double i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1,100);
        }
}

void PrintArray(double[] array)
{
    for(double i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
}

Console.WriteLine($"-> {difference = max - min}");