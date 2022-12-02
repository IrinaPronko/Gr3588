// Программа вывода наибольшего из двух чисел
System.Console.WriteLine("Введите два числа!");
System.Console.Write("первое число - ");
string? num1line = System.Console.ReadLine();
System.Console.Write("второе число - ");
string? num2line = System.Console.ReadLine();
int numberA = int.Parse(num1line);
int numberB = int.Parse(num2line);
System.Console.Write("Наибольшее введенное число - ");
if(numberA > numberB)
{
System.Console.WriteLine(numberA);
}
else
{
System.Console.WriteLine(numberB);
}

