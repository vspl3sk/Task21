// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int ax = Coord("x", "A");
int ay = Coord("y", "A");
int az = Coord("z", "A");
int bx = Coord("x", "B");
int by = Coord("y", "B");
int bz = Coord("z", "B");

int Coord(string coordName, string pointName)
{
    Console.Write($"Введите координату {coordName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}
double dist = Math.Round(Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2)), 2);

Console.WriteLine($"Расстояние между двумя точками в пространстве равно {dist}");