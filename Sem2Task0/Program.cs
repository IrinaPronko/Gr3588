// на вход трёхзначное число и на выходе показывает вторую цифру этого числа
System.Console.Write("Введите трехзначное число - ");
string? number1line = System.Console.ReadLine();
if(number1line!=null)
{
    // если первую цифру принять за 0, вторую за 1, третю за 2, то в квадратных скобках пишем 1
    System.Console.WriteLine("вторая цифра этого числа - " + number1line[1]);
    System.Console.WriteLine("_____________________________________________");
    System.Console.WriteLine("А еще:");
    System.Console.WriteLine("первая цифра этого числа - " + number1line[0]);
    System.Console.WriteLine("третья цифра этого числа - " + number1line[2]);
}
