// Программа поиска точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2
// программа
double res_Х = 0;
double res_y = 0;
Console.WriteLine ("Введите значения коэффициентов функции y=k*x+b :");
double k1 = ReadData("Для первой прямой - к1 ---> ");
double b1 = ReadData("                  - b1 ---> ");
double k2 = ReadData("Для второй прямой - к2 ---> ");
double b2 = ReadData("                  - b2 ---> ");
res_Х = (b2 - b1) / (k1 - k2);
res_y = k1 * res_Х + b1;
Console.WriteLine("Прямые пересекаются в точке с координатами [{0:f2}; {1:f2}]", res_Х, res_y);

double ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine() ?? "0");
}