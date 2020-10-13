

using System.Security.Cryptography.X509Certificates;

namespace Geometria
{
    class Ejercicios
    {
        //Ejercicio: Hacer una función que imprima por pantalla los números  del 0 al 99
        //Haz una función que imprima los números pares que hay desde el 0 hasta n
        public static void Ejercicio1()
        {
            int a;
            a = 0;
            while (a < 100)
            {
                System.Console.WriteLine(a);
                // a +=1
                // a = a +1
                a ++ ;

            }
             
        }
        public static void Ejercicio2(int n)
        {
            int i;
            i = 0;
    

            while (i < n)
            {
                if (Utils.IsEven(i) == true)
                    System.Console.WriteLine(i);
                i++;
            }

        }
        public static void Ejercicio3(int numero)
        {

            if (Utils.IsPrime(numero) == true)
                System.Console.WriteLine(numero + " es un numero primo");
            else
                System.Console.WriteLine(numero + " no es numero primo");
        }
     
            
        public static void Ejercicio4 ()
        {
            int i;
            i = 0;
            while (i <= 100)
            {
                System.Console.WriteLine(i);
                i++;
            }
        }
        public static void Ejercicio5()
        {
            int i;
            i = 0;
            while (i <= 100)
            {
                System.Console.WriteLine(i * 3);
                i++;
            }
        }
        public static void Ejercicio6()
        {
            int i;
            i = 0;
            while (i <= 100)
            {
                if (Utils.IsEven(i))    
                    System.Console.WriteLine(i);
                else
                    System.Console.WriteLine(-i);
                i++;
            }
        }

        public static void Ejercicio7()
        {
            int i;
            i = 0;
            int a = 1;
            int aa = 0;
            while (i <= 10)
           
            {
                    System.Console.WriteLine(a+aa);
                        int aux = a;
                        a = a + aa;
                        aa = aux;
                        i++;
                
            }
            
        }

    }
}
