// Программа нахождения произведения двух матриц 
// программа
int m = ReadData("Введите количество строк --->  ");
int n = ReadData("Введите количество столбцов --->  ");
int[,] arr1 = Gen2Arr(m, n);
int[,] arr2 = Gen2Arr(m, n);
Console.WriteLine("Первая матрица:");
Print2DArr(arr1);
Console.WriteLine("Вторая матрица:"); 
Print2DArr(arr2);
Console.WriteLine("_____________________________________________________________________");
Console.WriteLine("Произведение двух матриц:");
int[,] arr_res = MatProd(arr1,arr2);
Print2DArr(arr_res);

//метод ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод, генерирующий двухмерный целочисленный массив
int[,] Gen2Arr(int arrLinLen, int arrClmLen)
{ 
    Random rnd = new();
    int[,] arr = new int[arrLinLen, arrClmLen];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(10, 99) / 10;
        }
    }
    return arr;
}

// метод вывода двухмерного массива
void Print2DArr(int[,] arr)
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

//метод нахождения произведения двух матриц 
int[,] MatProd(int[,] arr1, int[,] arr2)
{
    int[,] arr_res = new int[m, n];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            arr_res[i, j] = 0;
            for (var k = 0; k < arr1.GetLength(1); k++)
            {
                    arr_res[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return arr_res;
}