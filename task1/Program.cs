/*Задача 56: Задайте прямоугольный двумерный массив.
 Напишите программу, которая будет находить строку
  с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в 
каждой строке и выдаёт номер строки с
 наименьшей суммой элементов: 1 строка */

 int[,] GenerateNewArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(deviation);
        }
    }
    return array;
}
void printColor(string information, ConsoleColor color, bool newline = false)
{
    Console.ForegroundColor = color;
    Console.Write(information);
    Console.ResetColor();
    if (newline)
    {
        Console.WriteLine();
    }
}
void print2dArray(int[,] array, string Name = " ")
{
    printColor(Name, ConsoleColor.DarkRed, true);
    Console.Write ("\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        printColor(i +"\t", ConsoleColor.DarkGreen,(i>=array.GetLength(1) -1));
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i + "\t", ConsoleColor.DarkBlue);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int StringArray(int [,]array, int i)
{
int summa = array[i,0];
for (int j = 0; j< array.GetLength(1); j++)
    {
    summa = summa + array[i,j];
    }
    return summa;
}
void minimumString (int [,] array)
{
    int count = 0;
    int min = StringArray(array,0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int Line = StringArray (array,i);
        if (min > Line)
        {
            min = Line;
            count = i;
        }
    }
    Console.WriteLine($"{count} the smallest.");
}

int[,] generatedArray = GenerateNewArray(3,3,10);
print2dArray(generatedArray, "Main massive");
Console.WriteLine();
minimumString(generatedArray);