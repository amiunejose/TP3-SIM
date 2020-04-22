using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneradorDeDistribuciones.Tools;

namespace GeneradorDeDistribuciones
{
    class GeneradorAleatorios
    {


        public double[] generarAleatorios01(int cantidad)
        {

            double[] vectorAleatorios = new double[cantidad];

            Random aleatorio = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                vectorAleatorios[i] = Truncate.truncar(aleatorio.NextDouble(), 4);
            }

            return vectorAleatorios;

        }




        //X = vectorUniforme[i];
        //A = limiteInferior;
        //B = limiteSuperior;
        //RND = vectorAleatorios[i];
        public double[] uniforme(double[] vectorAleatorios , double limiteInferior , double limiteSuperior)
        {
            // obtengo cantidad de numeros a generar
            int cantidad = vectorAleatorios.Length;



            // Genero vector con distribucion uniforme (A-B)
            double[] vectorUniforme = new double[cantidad];
            for ( int i=0 ; i<cantidad ; i++ )
            {
                // X = A + RND * (B-A);  -> Formula para generar Uniformes (A-B)
                double X = limiteInferior + vectorAleatorios[i] * (limiteSuperior - limiteInferior);
                vectorUniforme[i] = Truncate.truncar(X , 4);
            }


            return vectorUniforme;
        }


        public double[] expNeg(double[] vectorAleatorios, double parametro, bool esFrecuencia)
        {
            int cantidad = vectorAleatorios.Length;
            double frecuencia = 0;


            // Verifico si el parametro ingresado es frecuencia.
            // True : Si es así lo copio tal cual (Frecuencia = parametro)
            // False : Si no lo es (porque es una media), calculo la frecuencia segun la media (Frecuencia = 1/parametro).
            if (esFrecuencia)
            {
                frecuencia = parametro;
            }
            else { frecuencia = 1 / parametro; }

            double[] vectorExpNeg = new double[cantidad];
            for ( int i=0 ; i<cantidad ; i++ )
            {
                // X = (-1/frecuencia) * ln(1 - RND)
                double X = (-1 / frecuencia) * Math.Log(1 - vectorAleatorios[i]);
                vectorExpNeg[i] = Truncate.truncar(X, 4);
            }

            return vectorExpNeg;

        }




        public double[] normal(double[] vectorAleatorios, double media, double desviacion)
        {
            int cantidad = vectorAleatorios.Length;


            double[] vectorNormal = new double[cantidad];
            for (int i = 0; i < cantidad; i += 2)
            {
                // N1 = ((-2 * ln(RND1)^0,5).cos(2.Pi.RND2)) * desviacion + media
                // N2 = ((-2 * ln(RND1)^0,5).sen(2.Pi.RND2)) * desviacion + media
                double RND1 = vectorAleatorios[i];
                double RND2 = vectorAleatorios[i + 1];
                double PI = Math.PI;

                double n1 = (Math.Pow(-2 * Math.Log(RND1), 0.5) * Math.Cos(2 * PI * RND2)) * desviacion + media;
                double n2 = (Math.Pow(-2 * Math.Log(RND1), 0.5) * Math.Sin(2 * PI * RND2)) * desviacion + media;

                vectorNormal[i] = Truncate.truncar(n1, 4);
                vectorNormal[i+1] = Truncate.truncar(n2, 4);
            }

            return vectorNormal;
        }




    }
}
