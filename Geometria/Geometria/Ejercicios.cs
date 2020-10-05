

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
    }
}
