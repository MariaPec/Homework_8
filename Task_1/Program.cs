// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int Prompt(string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int row = Prompt("Введите число строк: ");
int column = Prompt("Введите число столбцов: ");
int [,] array = GenerateArray(row, column, 0, 9);
PrintArray(array);


void SortArray (int[,]array)
{
for (int k = 0; k < array.GetLength(0); k++)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 1; j < array.GetLength(1)-k;j++)
        {
           if (array[i, array.GetLength(1) - j - 1] < array[i,array.GetLength(1) - j])
        {
            int temp = array[i, array.GetLength(1) - j - 1]; 
            array[i, array.GetLength(1) - j- 1] = array[i, array.GetLength(1) - j];
            array[i, array.GetLength(1) - j] = temp;
        } 
       
        }
    }
}
    

}

Console.WriteLine("");
SortArray(array);
PrintArray(array);



