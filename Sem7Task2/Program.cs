// Программа формирования двумерного массива из целых чисел и поиск среднего арифметического элементов 
// в каждом столбце

int arr_Lin_Len = ReadData("Введите количество строк --->  ");
int arr_Clm_Len = ReadData("Введите количество столбцов --->  ");
int[,] arr = Gen2Arr(arr_Lin_Len, arr_Clm_Len);
Console.WriteLine("Сгенерированный массив:");
Print2Arr(arr);
Console.WriteLine("Среднее арифмeтическое элементов в каждом столбце:");
double[] res = new double[arr_Clm_Len];
Аverage(arr, arr_Lin_Len);
PrintArrReal(res);

//метод ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод, генерирующий двумерный целочисленный массив
int[,] Gen2Arr(int arr_Lin_Len, int arr_Clm_Len)
{ 
    Random rnd = new();
    int[,] arr = new int[arr_Lin_Len, arr_Clm_Len];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(10, 99);
        }
    }
    return arr;
}

// метод вывода двумерного массива
void Print2Arr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int temp1 = i;
        int temp2 = 0;
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            Console.Write (arr[i,j] + ", ");
            temp2 = j + 1;
        }
        Console.WriteLine("{0}", arr[temp1,temp2] + "]");
    }
}

//метод подсчета среднего арифметического элементов каждого столбца
void Аverage(int [,] arr, int arr_Lin_Len)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0) - 1; i++)
        {
            sum = sum + arr[i,j];
        }
        res[j] = sum / arr_Lin_Len;
    }
}
// метод вывода массива вещественных чисел
void PrintArrReal(double[] arr)
{
Console.Write("[");
for(int i = 0; i < arr.Length-1; i++)
{
Console.Write("{0:f2}", arr[i]);
Console.Write("; ");
}
int j = arr.Length - 1;
Console.Write("{0:f2}", arr[j]);
Console.WriteLine("]");
}
