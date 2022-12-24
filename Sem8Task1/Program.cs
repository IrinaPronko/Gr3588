// Программа, которая находит строку с наименьшей суммой элементов в двухмерном массиве
// программа
int arrLinLen = ReadData("Введите количество строк --->  ");
int arrClmLen = ReadData("Введите количество столбцов --->  ");
int[,] arr = Gen2Arr(arrLinLen, arrClmLen);
Console.WriteLine("Сформированный массив:");
Print2DArr(arr);
Console.WriteLine("____________________________________________");
int sumLine = 0;
int minSumLine = 0;
minSumLine = MinRow(arr);
Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");

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
            arr[i,j] = rnd.Next(10, 99);
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
        string str = " ";
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            str = String.Format("{0:d2}", arr[i,j]);
            Console.Write (str + ", ");
            temp2 = j + 1;
        }
        str = String.Format("{0:d2}", arr[temp1,temp2]);
        Console.WriteLine(str + "]");
    }
}

//метод определения строки с минимальной суммой элементов
int MinRow(int[,] arr)
{
    sumLine = SumLineElements(arr, 0);
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(arr, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }
    return minSumLine;
}

//метод определения суммы элементов в строке
int SumLineElements(int[,] arr, int i)
{
  int sumLine = arr[i,0];
  for (int j = 1; j < arr.GetLength(1); j++)
  {
    sumLine += arr[i,j];
  }
  return sumLine;
} 