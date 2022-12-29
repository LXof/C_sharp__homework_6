// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите M чисел: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(m);
PrintArray(array);

Console.Write($"количество чисел больше 0: {GetNumMoreZero(array)}");


int[] CreateArray(int amound)
{
    Random random = new Random();
    int[] array = new int[amound];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int GetNumMoreZero(int[] arrayNum)
{
    int result = 0;
    for (int i = 0; i < arrayNum.Length; i++)
    {
        if (arrayNum[i] > 0)
            result++;
    }
    return result;
}