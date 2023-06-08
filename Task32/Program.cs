// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на отрицательные и наоборот:
// [-4, -8, 8, 2] -> [4, 8, -8, 2]

// 1. Задать массив определенной длины (из случайных чисел)
// 2. Задать длину этого массива
// 3. Создать функцию, заменающие знак во всех элементах
// 4. вывести исходный массив
// 5. вывести новый массив

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

int [] newArray( int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
       array[i] *= -1;
    }
    return array;
}

int length = GetLength();
int [] array = GenArray(length);
string arrayToStr = String.Join(",", array);
Console.WriteLine($"Изначальный массив: {arrayToStr}");
int [] newarray = newArray(array);
string newarrayToStr = String.Join(",", newarray);
Console.WriteLine($"Измененный массив: {newarrayToStr}");