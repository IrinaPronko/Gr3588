// Принимает 3 числа и выдает максимальное
System.Console.WriteLine("Введите три числа!");
System.Console.Write("первое число - ");
string? num1line = System.Console.ReadLine();
System.Console.Write("второе число - ");
string? num2line = System.Console.ReadLine();
System.Console.Write("третье число - ");
string? num3line = System.Console.ReadLine(); 
if(num1line!=null&&num2line!=null&&num3line!=null)
{
    int numberA = int.Parse(num1line);
    int numberB = int.Parse(num2line);
    int numberC = int.Parse(num3line);
    int maxnumber = numberA; 

    System.Console.Write("Наибольшее введенное число - ");
    if(maxnumber < numberB)
    {
    maxnumber = numberB;
    }
    if(maxnumber < numberC)
    {
    maxnumber = numberC;  
    }
System.Console.WriteLine(maxnumber);
}

