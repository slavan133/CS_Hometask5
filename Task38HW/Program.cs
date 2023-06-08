// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int length = GetLength();
double [] array = GenArray(length);
double difmaxmin = DifMaxMin(array);
// Console.WriteLine($"Массив: {array}");
Console.WriteLine($"Разница между максимальным и минимальным: {difmaxmin}");

double [] GenArray (int Length) 
{
    double [] array = new double [Length];
    for (int i=0; i<Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble(), 2);
    }
    return array;
}

int GetLength() 
{
    Console.WriteLine("Введите длину:");
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

double DifMaxMin(double [] array)
{
   double min = array.Min();
   double max = array.Max();
   double dif = max - min;
   return dif;
}