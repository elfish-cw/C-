// а вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double Length(int xpos1, int xpos2, int ypos1, int ypos2, int zpos1, int zpos2)
{
    return Math.Sqrt((xpos2 - xpos1)*(xpos2 - xpos1) + (ypos2 - ypos1)*(ypos2 - ypos1) + (zpos2 - zpos1)*(zpos2 - zpos1));
}
double result = Math.Round(Length(x1,x2,y1,y2,z1,z2),2,MidpointRounding.ToZero);
Console.WriteLine($"расстояние между точками = {result}");
