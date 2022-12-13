// задает массив из 8 элементов и выводит их на экран
int ReadData (string msg)
{
    Console.WriteLine(msg);
    return int.Parse (Console.ReadLine() ?? "0");
}

// метод вывода на экран
void PrintData(string res, int[] arr)
{
    Console.WriteLine (res);
    PrintArr(arr);
}

// вводим метод, генерирующий массив
int[] GenArr(int num)
{ 
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 10000);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write (arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// программа
int arrLen = ReadData("Введите длину массива");

int[] arr = GenArr(arrLen);

PrintData("Сгенерированный массив:", arr);

