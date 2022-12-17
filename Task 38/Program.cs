//task 38
void InputArray(Double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToDouble(Console.ReadLine()); // пользователь сам вводит вещественные (дробные) числа
}

void Delta(Double[] array)
{
    Double Min = array[0], Max = 0;
    { for (int i = 0; i < array.Length; i++)
        if (array[i] > Max)
            Max = array[i];
        else 
        if (array[i] < Min)
            Min = array[i];
    }
Console.WriteLine($"Max : {Max}");
Console.WriteLine($"Min : {Min}");
Console.WriteLine($"Max-Min= {Max-Min}");
}

Console.Clear();
Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Double[] array = new Double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(",  ", array)}]");
Delta(array);