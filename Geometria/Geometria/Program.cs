
using System;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace Geometria
{
    class Geometry
    {
        public static double GetVectorLenght(double x, double y, double z)
        {
            double aux;
            aux = x * x + y * y + z * z;
            double lenght;
            lenght = System.Math.Sqrt(aux);
            return lenght;
        }
        static void Main(string[] args)
        {
            double s1;
            int s3, s4;
            bool s6, s7;


            s1 = Geometry.GetVectorLenght(1.0, 1.0, 1.0);
            System.Console.WriteLine("El resultado del vector es " + s1);

            s3 = Utils.GetMinValue(1, 1);
            System.Console.WriteLine("El numero más pequeño es " + s3);

            s4 = Utils.GetMaxValue(2, 5);
            System.Console.WriteLine("El numero más grande es " + s4);

            s6 = Utils.IsEven(5);
            System.Console.WriteLine(s6);

            Ejercicios.Ejercicio1();
            Ejercicios.Ejercicio2(10);

            s7 = Utils.IsPrime(13);
            System.Console.WriteLine(s7);


        }
        

    }
}