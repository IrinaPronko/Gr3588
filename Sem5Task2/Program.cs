// Массив вещественных чисел. Найти разность между мин и мах элементами массива

// программа
int arrLen = ReadData("Введите количество элементов массива --->  ");
int minVal = ReadData("Введите минимальное значение элемента массива --->  ");
int maxVal = ReadData("Введите максимальное значение элемента массива --->  ");
double[] arr = GenArr(arrLen, minVal, maxVal);
Print1DArr("Сгенерированный массив:", arr); 
double minNum = maxVal;
double maxNum = minVal;
MinMax(arr);
double res = maxNum - minNum;
PrintData ("Разность между мах и мин элементами массива равна ---> {0:f3}", res);

//метод ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// генерировать массив
double[] GenArr(int arrLen, int minVal, int maxVal)
{ 
    Random random = new Random();
    double[] arr = new double[arrLen];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.NextDouble() + random.Next(minVal, maxVal - 1);
    }
    return arr;
}

// метод поиска минимального и максимального значения массива
void MinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNum)
            minNum = arr[i];
        if (arr[i] > maxNum)
            maxNum = arr[i];
    }
}

// метод формирования вывода массива
void PrintArr(double[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write("{0:f3}", arr[i]);
        Console.Write(", ");
    }
    int j = arr.Length - 1;
    Console.Write("{0:f3}", arr[j]);
    Console.WriteLine("]");
}

// метод вывода одномерного массива
void Print1DArr(string msg, double[] arr)
{
    Console.WriteLine (msg);
    PrintArr(arr);
}

//метод вывода данных
void PrintData(string msg, double res)
{
    Console.WriteLine(msg, res);
}
