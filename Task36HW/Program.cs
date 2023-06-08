// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Примечание: судя по примерам в задаче, имеются ввиду именно нечетные индексы, поэтому суммировал элем. с нечетными индексами.

int [] GenArray (int Length) 
{
    int [] array = new int [Length];
    for (int i=0; i<Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
    return array;
}

int GetLength() 
{
    Console.WriteLine("Введите длину:");
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

int SearchNechetn (int [] array)
{
    int sum = 0;
   for (int i=0; i<array.Length; i++)
    {
       if (i%2 != 0)
       {
        sum += array[i];
       }
    }
    return sum;
}

int length = GetLength();
int [] array = GenArray(length);
int searchnechetn = SearchNechetn(array);
string arrayToStr = String.Join(",", array);
Console.WriteLine($"Массив: {arrayToStr}");
Console.WriteLine($"Сумма элементов на нечетных позициях (с нечетными индексами): {searchnechetn}");