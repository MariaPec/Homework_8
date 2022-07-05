// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int rowFirst = Prompt("Введите число строк в первой матрице: ");
int columnFirst = Prompt("Введите число столбцов в первой матрице: ");
int [,] arrayFirst = GenerateArray(rowFirst, columnFirst, 0, 9);
int rowSecond = Prompt("Введите число строк во второй матрице: ");
int columnSecond = Prompt("Введите число столбцов во второй матрице: ");
int [,] arraySecond = GenerateArray(rowSecond, columnSecond, 0, 9);
PrintArray(arrayFirst);
Console.WriteLine(" ");
PrintArray(arraySecond);

if (columnFirst != rowSecond) Console.WriteLine("Матрицы несовместимы. Число столбцов в первой матрице должно быть равно числу строк во второй");
else
{
int [,] newArray = new int[rowFirst, columnSecond];

int temp = 0;
 for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
          for (int k = 0; k < columnFirst; k++)
          {
            temp = temp + arrayFirst[i,k] * arraySecond[k,j];
          }
          newArray [i,j] = temp;
          temp = 0;
}
    }
    Console.WriteLine(" ");
    PrintArray(newArray);
}


