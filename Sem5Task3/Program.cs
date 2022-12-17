// Сформировать целочисленный массив, отсортировать его методом "пузырька" и вывести разность между его максимальным и минимальным значением
// программа
int arrLen = ReadData("Введите количество элементов массива --->  ");
int minVal = ReadData("Введите минимальное значение элемента массива --->  ");
int maxVal = ReadData("Введите максимальное значение элемента массива --->  ");
int[] arr = GenArr(arrLen, minVal, maxVal);
Print1DArr("Сгенерированный массив:", arr);
BubbleSort(arr);
Print1DArr("Отсортированный массив:", arr);
int res = arr[arrLen-1] - arr[0];
PrintData ("Разность между мах и мин элементами массива равна ---> {0}", res);


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

// метод сортировки массива "пузырьком"
void BubbleSort(int[] arr)
{
    int temp1 = 0;
    int temp2 = 0;
    for (int i = 0; i < arrLen; i++)
    {
        for (int j = 0; j < arrLen - 1 - i; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                temp1 = arr[j];
                temp2 = arr[j + 1];
                arr [j] = temp2;
                arr [j + 1] = temp1;
            }
        }
    }
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

// метод вывода одномерного массива на экран
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
