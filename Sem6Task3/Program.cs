// Программа поиска точек пересечения прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2
// в случае задания трех прямых считает площадь треугольника
// программа
int num_dir=ReadData("Введите количество прямых ----> ");                                                               // ввод количества прямых на плоскости
double[] k = new double [num_dir];                                                                                      // задание массива хранения коэффициентов K уравнени
double[] b = new double [num_dir];                                                                                      // задание массива хранения коэффициентов B уравнения
double[] res_x = new double [num_dir];                                                                                  // задание массива для хранения координат X точек пересечения
double[] res_y = new double [num_dir];                                                                                  // задание массива для хранения координат Y точек пересечения
double[] distance = new double [num_dir];                                                                               // задание массива для хранения расстояний между точками пересечения
Console.WriteLine("Введите значения коэффициентов функции y=k*x+b:");
for(int m = 0; m < num_dir; m++)
{
    Console.WriteLine("Для {0} прямой", m + 1);
    k[m] = ReadData_Real("            - к ---> ");
    b[m] = ReadData_Real("            - b ---> ");
}
int i = 0;
if (num_dir > 2)
{
    res_x[num_dir-1] = (b[num_dir-1] - b[0]) / (k[0] - k[num_dir-1]);
    res_y[num_dir-1] = k[0] * res_x[0] + b[0];
    Console.WriteLine("Прямые 1 и {0} пересекаются в точке с координатами [{1:f2}; {2:f2}]", num_dir, res_x[num_dir-1], res_y[num_dir-1]);
    while(i < num_dir-1)
    {
        Intersection_point(i);
        i++;
    }
}
else
{
    Intersection_point(i);
    goto ExitProgram;
}
if(num_dir != 3) goto ExitProgram;
else
{
// расчет расстояния между точками пересечения прямых
distance[num_dir - 1]= Math.Sqrt((res_x[num_dir-1]-res_x[0])*(res_x[num_dir-1]-res_x[0]) + (res_y[num_dir-1]-res_y[0])*(res_y[num_dir-1]-res_y[0]));  
i = 0;
while(i < num_dir-1)
{
        distance[i] = Math.Sqrt((res_x[i+1]-res_x[i])*(res_x[i+1]-res_x[i]) + (res_y[i+1]-res_y[i])*(res_y[i+1]-res_y[i]));
        i++;
}
// расчет площади треугольника с помощью формулы Герона
double a1 = distance[0];
double a2 = distance[1];
double a3 = distance[2];
double p = (a1 + a2 + a3) / 2;
double s = Math.Sqrt(p * (p - a1) * (p - a2) * (p - a3));
PrintData ("Площадь треугольника равна ---> {0:f2}", s);
}
ExitProgram:

// метод расчета координат точки пересечения двух прямых
void Intersection_point(int i)
{
    int j = i + 1;
    res_x[i] = (b[j] - b[i]) / (k[i] - k[j]);
    res_y[i] = k[i] * res_x[i] + b[i];
    int temp1 = i + 2;
    Console.Write("Прямые {0} и {1} пересекаются в точке с координатами ", j, temp1);
    int temp2 = i;
    Console.WriteLine("[{0:f2}; {1:f2}]", res_x[temp2], res_y[temp2]);
}

// метод ввода значений
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод ввода вещественных чисел
double ReadData_Real(string msg)
{
    Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine() ?? "0");
}

//метод вывода данных
void PrintData(string msg, double s)
{
    Console.WriteLine(msg, s);
}
