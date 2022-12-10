// принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
System.Console.Write("Введите число - ");
string? number1line = System.Console.ReadLine();
System.Console.WriteLine("___________________________");
System.Console.WriteLine("|   Таблица кубов чисел   |");
System.Console.WriteLine("___________________________");
if(number1line!=null)
{
    int numberN = int.Parse(number1line);
        for (int i = 1; i <= numberN; i++)
        {
            System.Console.Write("      ");
            System.Console.WriteLine("{0}^3 = {1}", i, i*i*i);
        }
}