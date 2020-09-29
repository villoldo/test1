using System;

namespace Geometria
{ class Geometry
{
    public static double GetVectorLenght(double x, double y)
    {
        double aux;
        aux = x * x + y * y;
        double lenght;
        lenght = System.Math.Sqrt(aux);
        return lenght;
    }
    static void Main(string[] args)
    {
        double s1;

        s1 = Geometry.GetVectorLenght(1.0, 1.0);
        System.Console.WriteLine("El resultado de la ecuacion es " + s1);
    }


}
}