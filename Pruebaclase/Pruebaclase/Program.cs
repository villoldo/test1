namespace HelloWorld
{
    class EquationSolve1
    {

        public static double SolveEquation1(double a, double b, double c)
        {
            double aux, aux2, x;

            aux = b * b - 4.0 * a * c;
            aux2 = System.Math.Sqrt(aux);
            x = (-b + aux2) / (2.0 * a);
            return x;
        }
        public static double SolveEquation2(double a, double b)
        {
            double x;
            x = -b / a;
            return x;
        }
    }
}
