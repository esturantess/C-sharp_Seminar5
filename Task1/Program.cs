// Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] arrayFill(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}


void arrayChange(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
}


void printArray(int[] array)
{
    System.Console.WriteLine("[ " + String.Join(", ", array) + " ]");
}

int[] array = arrayFill(6, -3, 3);


printArray(array);
arrayChange(array);
printArray(array);