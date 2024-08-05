// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int minrange = ReadInt("Введите минимальное значение элемента массива: ");
    int maxrange = ReadInt("Введите максимальное значение элемента массива: ");
    int[] Array = GenerateArray(arraySize, minrange, maxrange);
    PrintArray(Array);
    System.Console.WriteLine("Элементы массива, начиная с конца: ");
    PrintArrayElements(Array, Array.Length - 1);
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(minValue, maxValue + 1);

    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArrayElements(int[] arr, int index)
{
    if (index < 0) return;
    {

        System.Console.Write(arr[index] + " ");
        PrintArrayElements(arr, index - 1);
    }
}

void PrintArray(int[] arrayForPrint)
{
    Console.WriteLine("Получившийся массив : " + string.Join(" ", arrayForPrint) + "");
}

Main();