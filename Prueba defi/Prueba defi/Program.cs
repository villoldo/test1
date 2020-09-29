namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1, s2, s3, s4, s5;
            {
                s1 = EquationSolve1.SolveEquation1(2.0, 3.0, 5.0);
                System.Console.WriteLine("El resultado de la ecuacion es " + s1);

                s2 = EquationSolve1.SolveEquation1(3.0, 4.0, 1.0);

                System.Console.WriteLine("El resultado de la ecuacion es " + s2);

                s3 = EquationSolve1.SolveEquation1(2.0, 3.0, 1.0);

                System.Console.WriteLine("El resultado de la ecuacion es " + s3);

                System.Console.WriteLine("El resultado de la suma de las dos ecuaciones es " + (s3 + s2));

                s4 = EquationSolve1.SolveEquation2(1.0, -3.0);

                System.Console.WriteLine("El resultado de la ecuación de primer grado es" + s4);

                s5 = EquationSolve1.SolveEquation2(2.0, -5.0);

                System.Console.WriteLine("El resultado de la ecuación de primer grado es" + s5);



            }





        }
    }
}
