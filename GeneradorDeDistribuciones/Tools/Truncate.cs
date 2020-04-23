using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDeDistribuciones.Tools
{
    class Truncate
    {

        //        def truncate(n, decimals= 0):
        //multiplier = 10 * *decimals
        //return int(n * multiplier) / multiplier


        public static double truncar (double num, int cantDecim)
        {
            double multiplicador = Math.Pow(10, cantDecim);
            double temp = Convert.ToDouble(Math.Truncate(num * multiplicador));
            double result = temp / multiplicador;

            return result;

        }
    }
}
