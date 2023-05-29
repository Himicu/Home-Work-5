// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void CreateArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
int SubtractionMinMax(int[] arr)
{
    int min = arr[0], max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
            if (min > arr[i])
            {
                min = arr[i];
                Console.WriteLine($"min - {min}"); //оставила для наглядности
            }
            if (max < arr[i])
            {
                max = arr[i];
                Console.WriteLine($"max - {max}"); //оставила для наглядности
            }
    }
    return (max - min);
}

Console.Write("Введите размер массива: ");
int size = InputNumber();
int[] array = new int[size];
CreateArray(array);
PrintArray(array);
Console.WriteLine(SubtractionMinMax(array));
