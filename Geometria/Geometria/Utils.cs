﻿
using System.Runtime.CompilerServices;

namespace Geometria
{
    class Utils
    {
        public static int GetMinValue(int a, int b)
        {
            if (a < b)
                return a;
            else
                return b;
        }
        public static int GetMaxValue(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        // Is even devuelve true si el valor es par
        // y false en caso contrario
        public static bool IsEven(int value)
        {
            if ((value % 2) == 0)
                return true;
            else
                return false;
        }

    }
}
