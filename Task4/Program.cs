// Задача: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

void MultArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int result = array[i] * array[array.Length - i - 1];
        System.Console.WriteLine(result);
    }
    if (array.Length % 2 != 0)
    {
        System.Console.WriteLine(array[array.Length / 2]);
    }
}

int[] array = FillArrayWithRandomNumbers(7, 1, 10);
System.Console.WriteLine("Изначальный массив: ");
PrintArray(array);
MultArray(array);