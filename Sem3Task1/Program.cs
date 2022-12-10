// принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
System.Console.WriteLine("Программа расчета расстояния между двумя точками");
// ввод координат первой точки
System.Console.Write("Введите координаты точки A ->");
System.Console.Write("     х = ");
string? coordinate_x1 = System.Console.ReadLine();
System.Console.Write("                                  y = ");
string? coordinate_y1 = System.Console.ReadLine();
System.Console.Write("                                  z = ");
string? coordinate_z1 = System.Console.ReadLine();
// ввод координат второй точки
System.Console.Write("Введите координаты точки B ->");
System.Console.Write("     х = ");
string? coordinate_x2 = System.Console.ReadLine();
System.Console.Write("                                  y = ");
string? coordinate_y2 = System.Console.ReadLine();
System.Console.Write("                                  z = ");
string? coordinate_z2 = System.Console.ReadLine();
// преобразование строковых переменных в числовой формат
double x1 = Convert.ToDouble(coordinate_x1);
double y1 = Convert.ToDouble(coordinate_y1);
double z1 = Convert.ToDouble(coordinate_z1);
double x2 = Convert.ToDouble(coordinate_x2);
double y2 = Convert.ToDouble(coordinate_y2);
double z2 = Convert.ToDouble(coordinate_z2);
// расчет расстояния между точками А и В и вывод результата
double distance_AB = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1)); // формула расчета расстояния
distance_AB = Math.Round(distance_AB, 4); // формула округления результата
System.Console.Write("Расстояние от точки A до точки B составляет ->    ");
System.Console.WriteLine(distance_AB);