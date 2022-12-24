// Программа, которая заполняет спирально массив (квадратный и прямоугольный)
//программа
int m = ReadData("Введите количество строк (не более 9) --->  ");
int n = ReadData("Введите количество столбцов (не более 9)--->  ");
int[,] arr = Gen2ArrSpir(m, n);
Console.WriteLine("Сформированный спиральный массив:");
Print2DArr(arr);


//метод ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод заполнения массива по спирали
int[,] Gen2ArrSpir(int m, int n)
{
    int[,] arr = new int[m,n];
    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;
    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= m * n)
    {
        arr[i,j] = k;
        if (i == Ibeg && j < n - Jfin - 1)
            ++j;
        else if (j == n - Jfin - 1 && i < m - Ifin - 1)
            ++i;
        else if (i == m - Ifin - 1 && j > Jbeg)
            --j;
        else
            --i;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != n - Jfin - 1))
        {
            ++Ibeg;
            ++Ifin;
            ++Jbeg;
            ++Jfin;
        }
        ++k;
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