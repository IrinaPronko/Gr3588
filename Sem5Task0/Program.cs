// массив заполненный случайными положительнымми трехзначными числами; показать количество четных чисел в массиве
// основная программа
int len = 120;
int res = 0;
int[] arr = GenArr(len);
Print1DArr("Сгенерированный массив:", arr);
res = CountEven(arr);
PrintData ("Количество четных чисел в массиве равно ---> {0}", res);

// метод вывода на экран
void PrintData(string msg, int res)
{
    Console.WriteLine(msg, res);
}

// вводим метод, генерирующий массив
int[] GenArr(int len)
{ 
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 999);
    }
    return arr;
}

// вывод на экран одномерного массива
void Print1DArr (string msg, int[] arr)
{
    Console.WriteLine (msg);
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine();
}

// метод подсчёта четных чисел
int CountEven (int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] % 2 == 0)
        {
            res++;
        }
    }
    return res;
}
