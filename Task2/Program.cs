// Задача: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4. массив [6, 7, 19, 345, 3] -> нет
// -3; Массив [6, 7, 19, 345, -3] -> да

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

void printArray(int[] array)
{
    System.Console.WriteLine("[ " + String.Join(", ", array) + " ]");
}

int inputNumb()
{
    System.Console.Write("Введите число: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    return numb;
}

bool numbCheck(int numb, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (numb == array[i])
        {
            return true;
        }
    }
    return false;
}

int[] arr = arrayFill(10, -5, 5);
printArray(arr);
int number = inputNumb();

if (numbCheck(number, arr))
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}