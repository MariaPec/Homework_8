// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

if (row == column)
{
    Console.WriteLine($"Массив будет квадратный, задайте другое количетсво строк => ");
    row = Prompt("Новое число строк: ");
}


int [,] array = GenerateArray(row, column, 0, 10);
PrintArray(array);

int sum = 0;
int count = 1;
int min = 0;

for(int j = 0; j < array.GetLength(1); j++)
{
    sum = sum + array[0,j];
    min = sum;
}


for (int i = 1; i < array.GetLength(0); i++)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i,j];
    }
   

    if (sum < min)
    {
        min = sum;
        
        count = i + 1;
        sum = 0;
    }
    else sum = 0;

}

Console.WriteLine($"Наименьшая сумма элементов в {count} строке и равна {min}");

