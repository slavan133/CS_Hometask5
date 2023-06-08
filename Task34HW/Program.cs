// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] GenArray (int Length) 
{
    int [] array = new int [Length];
    for (int i=0; i<Length; i++)
    {
        array[i] = new Random().Next(100,999);
    }
    return array;
}

int GetLength() 
{
    Console.WriteLine("Введите длину:");
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

int SearchChetn (int [] array)
{
    int count = 0;
    foreach (int number in array)
    {
        if (number%2==0)
        {
            count++;
        }
    }
    return count;
}


int length = GetLength();
int [] array = GenArray(length);
int searchchetn = SearchChetn(array);
string arrayToStr = String.Join(",", array);
Console.WriteLine($"Массив: {arrayToStr}");
Console.WriteLine($"Количество четных: {searchchetn}");
