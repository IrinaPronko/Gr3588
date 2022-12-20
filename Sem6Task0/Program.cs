// User вводит с клавиатуры М чисел, программа должна определить сколько чисел > 0 ввёл user
// программа
int res = 0;
int arrLen = ReadData("Введите количество вводимых чисел --->  ");
int[] arr = Read_Arr(arrLen);
Print1DArr("Сгенерированный массив:", arr);
PrintData ("Количество введенных положительных чисел равно ---> {0}", res);

//метод ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// формирование массива данных с клавиатуры с одновременной проверкой положительное число или нет
int[] Read_Arr(int arrLen)
{ 
    int[] arr = new int[arrLen];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(" введите {0} число из {1}  ---> ", i + 1, arrLen);
        arr[i] = int.Parse(Console.ReadLine() ?? "0");
        if (arr[i] > 0)
        {
            res ++; //если введенное число положительное, то добавляем к результату единицу
        }  
    }
    return arr;
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