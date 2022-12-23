// Формирование двумерного массива размером m × n, заполненными случайными вещественными числами
// программа
int m = ReadData("Введите количество строк --->  ");
int n = ReadData("Введите количество столбцов --->  ");
double[,] arr = Gen2ArrReal(m, n);
Console.WriteLine("Сгенерированный массив:");
Print2ArrReal(arr);

//метод ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод, генерирующий двумерный вещественный массив
double [,] Gen2ArrReal(int m, int n)
{ 
    Random rnd = new();
    double[,] arr = new double[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Convert.ToDouble(rnd.Next(-1000, 1000)/100.0);
        }
    }
    return arr;
}

// метод вывода двумерного массива вещественных чисел
void Print2ArrReal(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int temp1 = i;
        int temp2 = 0;
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            Console.Write ("{0:f2}", arr[i,j] + ", ");
            temp2 = j + 1;
        }
        Console.WriteLine("{0:f2}", arr[temp1,temp2] + "]");
    }
}
