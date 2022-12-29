// Дополнительная задача (задача со звёздочкой): 
//Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.

//[8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
//[8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо

Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int amoundArray = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите МИНИМАЛЬНЫЙ элемент массива\nMin = ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите МАКСИМАЛЬНЫЙ элемент массива\nMax = ");
int max = Convert.ToInt32(Console.ReadLine());

if (max > min)
{
    int[] array = CreateArray(amoundArray, min, max);
    PrintArray(array);

    Console.WriteLine("Сдвинуть элементы:\nВведите команду\t0 - Влево,\n\t1 - Вправо");
    int shift = Convert.ToInt32(Console.ReadLine());
    Print(array, shift);
}






int[] CreateArray(int amoundArr, int min, int max)
{
    Random random = new Random();
    int[] createArray = new int[amoundArr];
    for (int i = 0; i < createArray.Length; i++)
    {
        createArray[i] = random.Next(min, max + 1);
    }
    return createArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}



void Print(int[] arr, int shift)
{ 
    switch (shift)
    {
        case 0:
                Console.WriteLine($"Сдвиг ВЛЕВО:");
                PrintArray(ShiftLeft(arr));
                break;
        case 1: 
                Console.WriteLine($"Сдвиг ВПРАВО:");
                PrintArray(ShiftRight(arr));
                break;
        default:
                Console.WriteLine($"Такой команды нет: {shift}");
                break;

    }

}

int[] ShiftRight(int[] arr)
{
    int temp = 0;
    temp = arr[arr.Length - 1];
    for (int i = arr.Length - 1; i < 0; i--)
    {
        arr[i] = arr[i - 1];
    }
    arr[0] = temp;
    return arr;
}

int[] ShiftLeft(int[] arr)
{
    int temp = 0;
    temp = arr[0];
    for (int i = 0; i < arr.Length - 1 ; i++)
    {
        arr[i] = arr[i + 1];
    }
    arr[arr.Length - 1] = temp;
    return arr;
}

