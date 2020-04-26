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
using CsvHelper;
using System.IO;

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
        private double mediaNormal;
        private double desviacion;


        // Distribucion Poisson
        private double mediaPoisson;

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
            gb_pruebas.Enabled = false;
            check_intervalos.Enabled = false;
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
                mediaNormal = Convert.ToDouble(txt_normal_media.Text);
                desviacion = Convert.ToDouble(txt_normal_desviacion.Text);

                // Inicializo el generador y genero las distribuciones
                GeneradorAleatorios generador = new GeneradorAleatorios();

                // Uniforme (0-1)
                vectorAleatorios = generador.generarAleatorios01(cantidad);

                // Normal
                vectorDistribucion = generador.normal(vectorAleatorios, mediaNormal, desviacion);


            }


            if (cb_TipoDistribucion.SelectedIndex == 3)
            {
                mediaPoisson = Convert.ToDouble(txt_poisson_media.Text);

                // Inicializo el generador y genero las distribuciones
                GeneradorAleatorios generador = new GeneradorAleatorios();

                // Uniforme (0-1)
                //vectorAleatorios = generador.generarAleatorios01(cantidad);

                // Poisson
                vectorDistribucion = generador.poisson(cantidad, mediaPoisson);

            }




        }









        private void llenarGrilla()
        {
            DataTable myDataTable = new DataTable();

            //Creo columnas
            

            if (cb_TipoDistribucion.SelectedIndex == 3)
            {
                myDataTable.Columns.Add("Indice", typeof(int));
                myDataTable.Columns.Add("-", typeof(string));
                myDataTable.Columns.Add("Distribucion Deseada", typeof(double));
                for (int i = 0; i < cantidad; i++)
                {
                    myDataTable.Rows.Add(i + 1, "-", vectorDistribucion[i]);
                }
                grilla_generados.DataSource = myDataTable;
            }
            else
            {
                myDataTable.Columns.Add("Indice", typeof(int));
                myDataTable.Columns.Add("Distribucion Uniforme (0-1)", typeof(double));
                myDataTable.Columns.Add("Distribucion Deseada", typeof(double));
                for (int i = 0; i < cantidad; i++)
                {
                    myDataTable.Rows.Add(i + 1, vectorAleatorios[i], vectorDistribucion[i]);
                }
                grilla_generados.DataSource = myDataTable;
            }

            
        }



        private double[] calcularRangos()
        {
            cantIntervalos = Convert.ToInt32(cb_intervalos.SelectedItem);

            if (check_intervalos.Checked)
            {
                cantIntervalos = vectorDistribucion.Length;
            }
            double[] vectorRangos = new double[cantIntervalos];
            double min = vectorDistribucion.Min();
            double max = vectorDistribucion.Max();
            double rango = max - min;
            double salto = rango / cantIntervalos;




            for (int i = 0; i < vectorDistribucion.Length; i++)
            {
                long indiceIntervalo = Convert.ToInt64(Math.Truncate((vectorDistribucion[i] - min) / salto));

                if (indiceIntervalo == cantIntervalos)
                {
                    indiceIntervalo = cantIntervalos - 1;
                }

                vectorRangos[indiceIntervalo] += 1;
            }


            return vectorRangos;
        }

        //private double[] calcularRangosPoisson()
        //{
        //    double[] vectorFormateado = new double[0];
        //}









        private void llenarGrafico()
        {

            string[] series;
            double[] vectorRangos;

            if (cb_intervalos.SelectedItem != null)
            {
                vectorRangos = calcularRangos();

                series = new string[vectorRangos.Length];
                for (int i = 0; i < cantIntervalos; i++)
                {
                    series[i] = i.ToString();
                }
                int[] puntos = new int[cantIntervalos];


                // SI ESTA SELECCIONADO EL CHECK PARA POISSON
                if (check_intervalos.Checked)
                {
                    List<double> vectorFormateado = new List<double>();
                    for (int i = 0; i < cantIntervalos; i++)
                    {
                        if (vectorRangos[i] > 0)
                        {
                            vectorFormateado.Add(vectorRangos[i]);
                        }
                    }

                    series = new string[vectorFormateado.Count];
                    for (int i = 0; i < vectorFormateado.Count; i++)
                    {
                        series[i] = i.ToString();
                    }
                    puntos = new int[vectorFormateado.Count];


                    for (int i = 0; i < vectorFormateado.Count; i++)
                    {
                        puntos[i] = Convert.ToInt32(vectorFormateado[i]);
                    }



                }
                else {
                    for (int i = 0; i < cantIntervalos; i++)
                    {
                        puntos[i] = Convert.ToInt32(vectorRangos[i]);
                    }
                }


                
                grafico.Series.Clear();
                for (int i = 0; i < puntos.Length; i++)
                {
                    Series serie = grafico.Series.Add(series[i]);
                    //serie.Label = puntos[i].ToString();
                    serie.Points.Add(puntos[i]);
                }
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



        private bool validarCampoNumerico(MaskedTextBox textBox, bool permiteCero)
        {
            if (textBox.Text == "")
            {
                textBox.Text = "0";
            }

            if (permiteCero == false && Convert.ToDouble(textBox.Text) <= 0)
            {
                return false;
            }

            return true;
        }





        private void Btn_generar_Click(object sender, EventArgs e)
        {

            if (validarCampoNumerico(txt_cantidad, false))
            {
                if (cb_TipoDistribucion.SelectedIndex != 2)
                {
                    tomarDatos();
                    llenarGrilla();
                    cb_intervalos.Enabled = true;
                    gb_pruebas.Enabled = true;
                    check_intervalos.Enabled = true;
                    MessageBox.Show("La serie se genero con exito!");
                }
                if (cb_TipoDistribucion.SelectedIndex == 2 && Convert.ToDouble(txt_cantidad.Text) > 1)
                {
                    tomarDatos();
                    llenarGrilla();
                    cb_intervalos.Enabled = true;
                    gb_pruebas.Enabled = true;
                    check_intervalos.Enabled = true;
                    MessageBox.Show("La serie se genero con exito!");
                } else {
                    if (cb_TipoDistribucion.SelectedIndex == 2)
                    { MessageBox.Show("Debe colocar una cantidad mayor a 1 para distribucion normal"); }
                     }
            }
            else { MessageBox.Show("Debe colocar una cantidad mayor a 0");}



            
        }









        private void Cb_intervalos_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarGrafico();
        }



        private void Btn_csv_Click(object sender, EventArgs e)
        {
            if (txt_cant_interv.Text == "")
            {
                txt_cant_interv.Text = "0";
            }

            if (Convert.ToInt32(txt_cant_interv.Text) > 0)
            {
                using (StreamWriter write = new StreamWriter("C:\\Users\\jose_\\OneDrive\\Escritorio\\Jose\\Facultad\\GitHub\\TP3-SIM\\Analizador Chi-Cuadrado\\2020Simulacion4k1-tp2\\test_files\\data.txt"))
                {

                    for (int i = 0; i < vectorDistribucion.Length; i++)
                    {
                        var temp = vectorDistribucion[i].ToString();
                        write.Write(temp.Replace(",","."));
                        if (i != vectorDistribucion.Length - 1)
                        {
                            write.Write(";");
                        }
                    }
                    write.WriteLine("");
                    write.WriteLine(cb_TipoDistribucion.SelectedIndex);
                    write.WriteLine(txt_cant_interv.Text);
                    // String command = @"C:\Users\jose_\OneDrive\Escritorio\Jose\Facultad\GitHub\TP3-SIM\Analizador Chi-Cuadrado\2020Simulacion4k1-tp2\\TP3.bat"; ProcessInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
                    // System.Diagnostics.Process.Start("C:\\Users\\jose_\\OneDrive\\Escritorio\\Jose\\Facultad\\GitHub\\TP3-SIM\\Analizador Chi-Cuadrado\\2020Simulacion4k1-tp2\\TP3.bat");
                }
            }
            else { MessageBox.Show("Debe colocar un valor de intervalos mayor a 0");  }

            

        }

        private void Check_intervalos_CheckedChanged(object sender, EventArgs e)
        {
            if (check_intervalos.Checked)
            {
                cb_intervalos.Enabled = false;
                llenarGrafico();
            }

            if (check_intervalos.Checked == false)
            {
                cb_intervalos.Enabled = true;
                llenarGrafico();
            }
        }
    }
}
