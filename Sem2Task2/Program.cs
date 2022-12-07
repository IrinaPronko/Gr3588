// принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.Write("Введите день недели - ");
string? number1line = System.Console.ReadLine();
if(number1line!=null)
{
    int numberDayWeek = int.Parse(number1line);
    if (numberDayWeek == 6 || numberDayWeek == 7)
        System.Console.WriteLine("Этот день недели является выходным");
    else
    {
        if (numberDayWeek < 1 || numberDayWeek > 7)
            System.Console.WriteLine("Вы ввели неправильный номер дня недели");
        else
            System.Console.WriteLine("Этот день недели не является выходным");
    }
}