// принимает число и выдает четное или нет
System.Console.Write("Введите число - ");
string? number1line = System.Console.ReadLine();
if(number1line!=null)
{
    int numberA = int.Parse(number1line);
    if(numberA % 2==1)
    {
    System.Console.WriteLine("введено нечетное число");
    }
    else    
    {
    System.Console.WriteLine("введено четное число");    
    }
}

