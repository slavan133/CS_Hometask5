// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int [] GenArray (int Length) 
{
    int [] array = new int [Length];
    for (int i=0; i<Length; i++)
    {
        array[i] = new Random().Next(1,10);
    }
    return array;
}

int GetLength() 
{
    Console.WriteLine("Введите длину:");
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

void XPar(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length/2; i++)
    {
        sum = array[i] * array[array.Length-1-i];
        Console.Write(sum + " ");
    }
    
}

int length = GetLength();
int [] array = GenArray(length);
string arrayToStr = String.Join(",", array);
Console.WriteLine($"Массив: {arrayToStr}");
XPar(array);
