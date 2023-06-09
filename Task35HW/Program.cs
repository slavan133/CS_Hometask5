// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат 
// в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int [] GenArray (int Length) 
{
    int [] array = new int [Length];
    for (int i=0; i<Length; i++)
    {
        array[i] = new Random().Next(1,124);
    }
    return array;
}

int GetLength() 
{
    Console.WriteLine("В данной задаче длина равна 123:");
    int length = 123;
    return length;
}

int Interval (int [] array)
{
    int sum = 0;
    
foreach (int number in array)  // c number не нужно образаться к каждому элементу массива, это уже перебор чисел массивов
{
    if (number >= 10 && number <= 99)
    {
    sum ++; 
    }
}

    return sum;   
}

int length = GetLength();
int [] array = GenArray(length);
int interval = Interval(array);
string arrayToStr = String.Join(",", array);
Console.WriteLine($"Массив: {arrayToStr}");
Console.WriteLine($"Количество элементов, значения которых лежат в диапазоне [10,99]: {interval}");