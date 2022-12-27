// Программа вычисления функции Аккермана с помощью рекурсии
//программа
int n = ReadData("Введите число N: --->  ");
int m = ReadData("Введите число M: --->  ");
int znach = FunAkk(n, m);
PrintData("Значение функции Аккермана A({0},{1}) = {2}", n, m, znach);

// метод ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод вывода результата
void PrintData(string msg, int n, int m, int znach)
{
    Console.WriteLine(msg, n, m, znach);
}

// рекурсивный метод расчета функции Аккермана
static int FunAkk(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return FunAkk(n - 1, 1);
    else
      return FunAkk(n - 1, FunAkk(n, m - 1));
}
