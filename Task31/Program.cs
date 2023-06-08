// Задача 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9;9].
// Найдите сумму отрицательных и положительных элементов массива.
// Пример [3,9,-8,1,0,-7,2,1,8,3,-1,-1,6] сумма положительных чисел 29, отрицательных -20.
// 1. Генерируем массив
// 2. Сумма положительных чисел
// 3. Сумма отрицательных чисел
// 4. Получение длины

int [] GenArray (int Length) {
    int [] array = new int [Length];

    for (int i=0; i<Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
    return array;
}

int GetLength() {
    Console.WriteLine("Введите длину:");
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

int SumPositiv (int [] array) 
{
    int sum = 0;
    for (int i=0; i<array.Length; i++)
    {
      if (array[i]>0)
      {
      sum += array[i];
      }
    }
    return sum;
}

int SumNegativ (int [] array) 
{
    int sum = 0;
    
foreach (int number in array)  // c number не нужно образаться к каждому элементу массива, это уже перебор чисел массивов
{
    if (number < 0)
    {
        sum += number; 
    }
}

    return sum;   
}

int length = GetLength();
int [] array = GenArray(length);
int sumPositiv = SumPositiv(array);
int sumNegativ = SumNegativ(array);
string arrayToStr = String.Join(",", array);
Console.WriteLine($"Сумма положительных {sumPositiv}, сумма отрицательных {sumNegativ}, массив: {arrayToStr}");