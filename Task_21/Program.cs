// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// d = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

void ShowLength(int xa, int xb, int ya, int yb, int za, int zb)
{
    double d = Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2) + Math.Pow((zb - za),2));
    Console.WriteLine(d);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int xa = GetInput ("Введите координату X для точки A: ");
int xb = GetInput ("Введите координату X для точки B: ");
int ya = GetInput ("Введите координату Y для точки A: ");
int yb = GetInput ("Введите координату Y для точки B: ");
int za = GetInput ("Введите координату Z для точки A: ");
int zb = GetInput ("Введите координату Z для точки B: ");

ShowLength(xa, xb, ya, yb, za, zb);