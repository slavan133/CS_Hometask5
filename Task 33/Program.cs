// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3]-> нет
// -3; массив [6, 7, 19, 345, 3]-> нет

int [] GenArray (int Length) 
{
    int [] array = new int [Length];
    for (int i=0; i<Length; i++)
    {
        array[i] = new Random().Next(-10,10);
    }
    return array;
}

int GetLength() 
{
    Console.WriteLine("Введите длину:");
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}


void Prisutstvie (int [] array, int nomer)
{
    bool check = false; // чисто "да" или "нет", далее при соответствии условию будет "да", без соответствия "нет"
    foreach (int number in array)
    {
        if (number == nomer)
        {
          check = true;
          break; // одно число нашли, дальше искать нет смысла
        }
    }
    if (check == true) {Console.WriteLine("Да");}
    else { Console.WriteLine("Нет");}
}

Console.WriteLine("Введите число:");
int chislo = Convert.ToInt32(Console.ReadLine());
int length = GetLength();
int [] array = GenArray(length);
string arrayToStr = String.Join(",", array);
Console.WriteLine($"Массив: {arrayToStr}");
Prisutstvie(array, chislo);
