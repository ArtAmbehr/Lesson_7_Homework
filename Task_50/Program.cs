// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// // и возвращает значение этого элемента или же указание, что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // [1,7] -> такого числа в массиве нет

Console.Write("Введите позицию элемента в строке массива: ");
int posRows = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите позицию элемента в столбце массива: ");
int posColumns = Convert.ToInt32(Console.ReadLine()) - 1;
Console.ReadLine();
int n = 3; 
int m = 4; 
Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("В нижеуказанном массиве ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
{
    arr[i, j] = random.Next(0, 10);
Console.Write("{0} ", arr[i, j]);
}
Console.WriteLine();
}
    if (posRows < 0 | posColumns > arr.GetLength(0) - 1 | posRows < 0 | posColumns > arr.GetLength(1) - 1)
{
Console.WriteLine("введенного Вами элемента не существует  ");
}
    else
{
    Console.WriteLine("Значение введенного Вами элемента равно {0}", arr[posRows, posColumns]);
}
Console.ReadLine();
