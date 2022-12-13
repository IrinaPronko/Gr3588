// программа, которая принимает на вход число и выдаёт сумму цифр в числе.
// метод ввода значений
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод вывода на экран
void PrintData(string msg, int res)
{
    Console.WriteLine(msg, res);
}

// метод суммирования цифр числа
int SumDigit(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + num % 10;
        num = num / 10;
    }
    return res;
    
}
// основная часть программы
int num = ReadData("Введите число --->  ");
int res = SumDigit(num);
PrintData ("Сумма цифр введенного числа равна ---> {0}", res);