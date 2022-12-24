// Сформировать двумерный целочисленный массив и упорядочить 
// по убыванию элементы каждой строки этого массива.
//программа
int arrLinLen = ReadData("Введите количество строк --->  ");
int arrClmLen = ReadData("Введите количество столбцов --->  ");
int[,] arr = Gen2Arr(arrLinLen, arrClmLen);
Console.WriteLine("Сгенерированный массив:");
Print2DArr(arr);
SortLineArr(arr);
Console.WriteLine("______________________________________________");
Console.WriteLine("Отсортированный массив:");
Print2DArr(arr);

//метод ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод, генерирующий двумерный целочисленный массив
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

// метод вывода двумерного массива
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

// Функция сортировки элементов в строке двумерного массива, по убыванию
void SortLineArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}