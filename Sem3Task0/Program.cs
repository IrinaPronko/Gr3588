// принимает на вход пятизначное число и проверяет, является ли оно палиндромом
System.Console.Write("Введите пятизначное число ---> ");
string? number = System.Console.ReadLine();
if (number != null) // проверка на отсуствие введенного значения
{
    int len = number.Length; // получение длины введенного значения
    if (len == 5) // проверка на соответствие, что введенное число является пятизначным
    {
        if (number[0] == number[4] && number[1] == number[3]) // проверка на соответствие, что первое значение соответствует последнему, а второе - предпоследнему
        {
            System.Console.WriteLine($"{number} - палиндром");
        }
        else
        {
            System.Console.WriteLine($"{number} - не палиндром");
        }
    }
    else
    {
        System.Console.WriteLine($"ОШИБКА: {number} - не является пятизначным числом");
    }
}