using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneradorDeDistribuciones;
using System.Windows.Forms.DataVisualization.Charting;
using GeneradorDeDistribuciones.Tools;

namespace GeneradorDeDistribuciones
{
    public partial class Generador : Form
    {

        private int cantidad;
        private double[] vectorAleatorios;
        private double[] vectorDistribucion;

        // Distribucion Uniforme
        private double limiteInferior;
        private double limiteSuperior;

        // Distribucion exponencial negativa
        private bool esFrecuencia;
        private double parametro;

        // Distribucion normal
        private double media;
        private double desviacion;


        // Distribucion Poisson


        // Grafico
        private int cantIntervalos;

        public Generador()
        {
            InitializeComponent();
        }

        private void Generador_Load(object sender, EventArgs e)
        {
            btn_generar.Enabled = false;
            gb_uniforme.Enabled = false;
            gb_exponencial.Enabled = false;
            gb_normal.Enabled = false;
            gb_poisson.Enabled = false;
            cb_intervalos.Enabled = false;
        }

        private void tomarDatos()
        {
            // Tomo valor de cantidad de numeros a generar
            cantidad = Convert.ToInt32(txt_cantidad.Text);



            // Si la distribucion seleccionada es "Uniforme" (index = 0)
            if (cb_TipoDistribucion.SelectedIndex == 0)
            {
                // Tomo los valores de los limites inferior y superior
                limiteInferior = Convert.ToDouble(txt_uniforme_li.Text);
                limiteSuperior = Convert.ToDouble(txt_uniforme_ls.Text);

                // Inicializo el generador y genero las distribuciones
                GeneradorAleatorios generador = new GeneradorAleatorios();

                // Uniforme (0-1)
                vectorAleatorios = generador.generarAleatorios01(cantidad);

                // Uniforme (A-B)
                vectorDistribucion = generador.uniforme(vectorAleatorios , limiteInferior , limiteSuperior);
            }



            // Si la distribucion seleccionada es "Exp Negativa" (index = 1)
            if (cb_TipoDistribucion.SelectedIndex == 1)
            {
                parametro = Convert.ToDouble(txt_expNeg_param.Text);

                if (cb_expNeg.SelectedIndex == 0)
                {
                    esFrecuencia = true;
                }
                else { esFrecuencia = false; }

                // Inicializo el generador y genero las distribuciones
                GeneradorAleatorios generador = new GeneradorAleatorios();

                // Uniforme (0-1)
                vectorAleatorios = generador.generarAleatorios01(cantidad);

                // Exponencial Negativa
                vectorDistribucion = generador.expNeg(vectorAleatorios, parametro, esFrecuencia); 

            }


            if (cb_TipoDistribucion.SelectedIndex == 2)
            {
                media = Convert.ToDouble(txt_normal_media.Text);
                desviacion = Convert.ToDouble(txt_normal_desviacion.Text);

                // Inicializo el generador y genero las distribuciones
                GeneradorAleatorios generador = new GeneradorAleatorios();

                // Uniforme (0-1)
                vectorAleatorios = generador.generarAleatorios01(cantidad);

                // Normal
                vectorDistribucion = generador.normal(vectorAleatorios, media, desviacion);


            }




        }





        private void llenarGrilla()
        {
            DataTable myDataTable = new DataTable();

            //Creo columnas
            myDataTable.Columns.Add("Indice", typeof(int));
            myDataTable.Columns.Add("Distribucion Uniforme (0-1)", typeof(double));
            myDataTable.Columns.Add("Distribucion Deseada", typeof(double));

            for (int i = 0; i < cantidad; i++)
            {
                myDataTable.Rows.Add(i+1, vectorAleatorios[i], vectorDistribucion[i]);
            }
            grilla_generados.DataSource = myDataTable;
        }



        private void llenarGrafico()
        {

            cantIntervalos = Convert.ToInt32(cb_intervalos.SelectedItem);
            int[] vectorRangos = new int[cantIntervalos];
            double min = vectorDistribucion.Min();
            double max = vectorDistribucion.Max();
            double rango = max - min;
            double salto = rango / cantIntervalos;
            string[] series = new string[cantIntervalos];

            for (int i = 0; i < cantIntervalos; i++)
            {
                series[i] = i.ToString();
            }



            for ( int i=0 ; i<vectorDistribucion.Length ; i++)
            {
                int indiceIntervalo = Convert.ToInt32(Math.Truncate((vectorDistribucion[i] - min) / salto));

                if (indiceIntervalo == cantIntervalos)
                {
                    indiceIntervalo = cantIntervalos - 1;
                }
                
                vectorRangos[indiceIntervalo] += 1;
            }

            int[] puntos = new int[cantIntervalos];
            for (int i = 0; i < cantIntervalos; i++)
            {
                puntos[i] = vectorRangos[i];
            }

            grafico.Series.Clear();
            for ( int i = 0 ; i<puntos.Length  ; i++ )
            {
                Series serie = grafico.Series.Add(series[i]);
                

                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);

            }
            

        }





        private void Cb_TipoDistribucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_generar.Enabled = true;

            if (cb_TipoDistribucion.SelectedIndex == 0)
            {
                gb_uniforme.Enabled = true;
                gb_exponencial.Enabled = false;
                gb_normal.Enabled = false;
                gb_poisson.Enabled = false;
            }

            if (cb_TipoDistribucion.SelectedIndex == 1)
            {
                gb_uniforme.Enabled = false;
                gb_exponencial.Enabled = true;
                gb_normal.Enabled = false;
                gb_poisson.Enabled = false;
            }

            if (cb_TipoDistribucion.SelectedIndex == 2)
            {
                gb_uniforme.Enabled = false;
                gb_exponencial.Enabled = false;
                gb_normal.Enabled = true;
                gb_poisson.Enabled = false;
            }

            if (cb_TipoDistribucion.SelectedIndex == 3)
            {
                gb_uniforme.Enabled = false;
                gb_exponencial.Enabled = false;
                gb_normal.Enabled = false;
                gb_poisson.Enabled = true;
            }


        }




        private void Btn_generar_Click(object sender, EventArgs e)
        {
            tomarDatos();
            llenarGrilla();
            cb_intervalos.Enabled = true;
        }

        private void Cb_intervalos_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarGrafico();
        }
    }
}
