// task 36
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101); // [-100, 100]
}

void Sum(int[] array)
{
    int Sum = 0;
    for (int i = 1; i < array.Length; i = i+2)
    {
        Sum = Sum + array[i];
            
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях в массиве: {Sum}");
}

Console.Clear();
Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; // {0, 0,....}
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Sum(array);
