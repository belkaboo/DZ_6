Console.Clear();
Console.Write("Введите кол-во чисел: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
if (!isParsedM)
{
    Console.WriteLine("Ошибка! Введено не натуральное число");
    return;
}

int[] UserFillArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        bool isParsedNum = int.TryParse(Console.ReadLine(), out int num);
        if (!isParsedNum)
        {
            Console.WriteLine("Ошибка, попробуйте ещё раз");
            i -= 1;
        }
        else
        {
            array[i] = num;
        }
    }
    return array;
}

int PositiveUserNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{

    Console.Write("[");
    for (var i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]"); 
    Console.WriteLine();
}

int[] array1 = UserFillArray(m);

PrintArray(array1); // для проверки

Console.WriteLine($"Вы ввели {PositiveUserNumbers(array1)} положительных чисел.");

Console.WriteLine();

Console.WriteLine("-= Вторая задача =-");
Console.WriteLine();

Console.WriteLine("Введите значения k1 и b1 для первого уравнения:");
Console.Write("b1 = ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1 = ");
var k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значения k2 и b2 для первого уравнения:");
Console.Write("b2 = ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 = ");
var k2 = Convert.ToDouble(Console.ReadLine());

if (k1 != k2)
{
    Console.WriteLine($"Координаты пересечения прямых :  {Coordinate(k1, b1, k2, b2)}");
}
else
{
    Console.WriteLine($"Заданные прямые параллельны. Ошибка -   {Coordinate(k1, b1, k2, b2)}");
}

(double, double) Coordinate(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}
