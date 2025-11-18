using Tyuiu.PolyakovaAS.Sprint0.Task6.V0.Lib;

int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine("Сумма элементов массива = " + DataSevice.AdditionArray(numsArray));
Console.WriteLine("Разность элементов массива = " + DataSevice.SubtractionArray(numsArray));
Console.WriteLine("Произведение элементов массива = " + DataSevice.MultiplicationArray(numsArray));

Console.ReadKey();