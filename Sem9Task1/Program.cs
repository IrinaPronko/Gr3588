//Программа поиска суммы натуральных элементов в диапазоне от M до N
//программа
int m = ReadData("Введите число M: --->  ");
int n = ReadData("Введите число N: --->  ");
int sum = 0;
sum = m < n ? SumMN(m, n):SumMN(n, m);
PrintData("Сумма натуральных элементов в диапазоне от M до N ---->  {0}", sum);

// метод ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод вывода результата
void PrintData(string msg, int sum)
{
    Console.WriteLine(msg, sum);
}

// рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N
int SumMN(int min, int max)
{
    if (max <= min)
    {
        return sum = sum + max;
    }
    else
    {
        sum = min + SumMN(min + 1, max);
        return sum;
    }
}
