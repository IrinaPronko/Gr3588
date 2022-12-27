// Программа принимает число N и выводит все натуральные числа в промежутке от N до 1
// программа
int num = ReadData("Введите число --->  ");
string resultLine = LineGenRec(num);
PrintDataStr(resultLine);

//метод ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод вывода на экран строки результата
void PrintDataStr(string msg)
{
    Console.WriteLine(msg);
}

// рекурсивный метод формирования строки натуральных чисел
string LineGenRec(int num)
{
    if (num <= 0)
    {
        return String.Empty;
    }
    else
    {
        string outLine = Convert.ToString(num) + " " + LineGenRec(num - 1);
        return outLine;
    }
}
