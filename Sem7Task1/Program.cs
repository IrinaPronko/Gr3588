// Программа на вход принимает позиции элемента в двумерном массиве и возвращает значение этого элемента 
// или же указание, что такого элемента нет

int arr_Lin_Len = ReadData("Введите количество строк --->  ");
int arr_Clm_Len = ReadData("Введите количество столбцов --->  ");
int[,] arr = Gen2Arr(arr_Lin_Len, arr_Clm_Len);
Console.WriteLine("Сгенерированный массив:");
Print2Arr(arr);
int pos1 = ReadData("Введите строку элемента --->  ");
int pos2 = ReadData("Введите столбец элемента --->  ");
FindElem(pos1, pos2);


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

// метод поиска элемента в массиве
void FindElem(int pos1, int pos2)
{
    if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", arr[pos1 - 1, pos2 - 1]);
    }
}
