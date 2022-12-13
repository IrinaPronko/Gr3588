// цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

//метод ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод вывода результата
void PrintData(string msg, double res)
{
    Console.WriteLine(msg, res);
}

// вводим метод возведения в степень
double Pow(int a, int b)
{
    double res = 1;
    for (int i = 1; i <= b; i++)
    {
        res = res * a;
    }
      return res;
}

// программа
int a = ReadData("Введите число --->  ");
int b = ReadData("Введите число --->  ");
double res = Pow(a, b);
PrintData ("Число a в степени b равно ---> {0}", res);
