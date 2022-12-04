// принимает N выдает все четные от 1 до N
System.Console.Write("Введите число - ");
string? number1line = System.Console.ReadLine();
// вводим две переменные - счетчик и для хранения четных чисел
int count = 1;
string outline = " ";
// переводим в число
if(number1line!=null)
{
    int numberA = int.Parse(number1line);
    // начинаем цикл
    while (count < numberA)
    {
        if(count % 2 == 0)
        {
        outline = outline + count + ";";
        }
        count = count + 1;
    }
    // проверка на четность числа N (numberA)
    if(numberA % 2 == 0)
    {
        outline = outline + numberA;
    }
// вывод четных с 1 по N    
System.Console.Write("четные числа диапазона - ");  
System.Console.WriteLine(outline);  
}
