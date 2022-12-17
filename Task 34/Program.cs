// task 34
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000); // [100, 999]
}

void Count(int[] array)
{
    int Count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            Count++;
    }
    Console.WriteLine($"Количество четных чисел в массиве: {Count}");
}

Console.Clear();
Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; // {0, 0,....}
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Count(array);
