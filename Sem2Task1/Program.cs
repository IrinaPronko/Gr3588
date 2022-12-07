// выводит третью цифру заданного числа или сообщает, что третьей цифры нет
System.Console.Write("Введите число - ");
string? number1line = System.Console.ReadLine();
if(number1line!=null)
{
    if(number1line.Length > 2)
        System.Console.WriteLine("третья цифра этого числа -> " + number1line[2]);
    else
        System.Console.WriteLine("третьей цифры нет");
}

