using Tyuiu.PolyakovaAS.Sprint0.Task7.V0.Lib;

int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine("Значение элементов массива №1");
for (int i = 0; i < arrayNums1.Length; i++) ;
{
    Console.Write(arrayNums1 + ", ");
}

Console.WriteLine();

int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine("Значение элементов массива №2");
for (int i = 0; i < arrayNums2.Length; i++) ;
{
    Console.Write(arrayNums2 + ", ");
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
if (arrayNums1.Length == arrayNums2.Length)
{
    int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

    Console.WriteLine("Сумма элементов массива ровна:");
    for (int i = 0; i < resultArray.Length; i++)
    {
        Console.Write(resultArray[i] + ", ");
    }
}
else
{
    Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
}
Console.ReadKey();