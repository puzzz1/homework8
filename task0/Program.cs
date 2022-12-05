/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по
убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/


int[,] GenerateNewArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(-deviation, deviation + 1);
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
int[,] bubbleArray(int [,]array)
{
for (int j = 0; j < array.GetLength(0); j++) 
{
    for (int i = 0; i < array.GetLength(1); i++) 
    {
        for (int k = 0; k < array.GetLength(1)-1; k++)
        {
            if (array[j,k] < array [j,k + 1])
            {
                int temp = 0;
                temp = array [j,k + 1];
                array[j,k + 1] = array[j,k];
                array[j,k]= temp;
            }
        }
    }
}
return array;


}

int[,] generatedArray = GenerateNewArray(5,3,10);
print2dArray(generatedArray, "Main massive");
Console.WriteLine();
int [,]changedArray = bubbleArray(generatedArray);
Console.WriteLine();
print2dArray(changedArray, "New massive");