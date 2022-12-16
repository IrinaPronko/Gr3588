// Одномерный массив заполненный случайными числами, найти сумму элементов стоящих в нечётных индексах.
// программа
int arrLen = ReadData("Введите количество элементов массива --->  ");
int minVal = ReadData("Введите минимальное значение элемента массива --->  ");
int maxVal = ReadData("Введите максимальное значение элемента массива --->  ");
int[] arr = GenArr(arrLen, minVal, maxVal);
int res = SumOdd(arr);
Print1DArr("Сгенерированный массив:", arr);
PrintData ("Сумма значений нечетных элементов массива равна---> {0}", res);


//метод ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// генерировать массив
int[] GenArr(int arrLen, int minVal, int maxVal)
{ 
    Random rnd = new Random();
    int[] arr = new int[arrLen];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal + 1);
    }
    return arr;
}

// метод суммирования значений элементов массива, стоящих на нечетных позициях
int SumOdd(int[] arr)
{
    int res = 0;
    int i = 1;
    while (i < arrLen)
    {
        res += arr[i];
        i = i + 2;
    }
    return res;
}

// метод формирования вывода массива
void PrintArr(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write (arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// метод вывода на экран
void Print1DArr(string msg, int[] arr)
{
    Console.WriteLine (msg);
    PrintArr(arr);
}

//метод вывода данных
void PrintData(string msg, int res)
{
    Console.WriteLine(msg, res);
}
