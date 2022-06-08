using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace configuracion_red_neuronal
{
    public partial class FromUnicapa : Form
    {
        BancoConfigService configService = new BancoConfigService();
        MatrizService matrizService = new MatrizService();
        public FromUnicapa()
        {
            InitializeComponent();
        }

        private void UNICAPA()
        {
            if (comboBoxTipoDeRed.Text.ToUpper().Equals("PERCEPTRON"))
            {
                comboBoxFuncion.Items.Clear();
                comboBoxRegla.Items.Clear();
                comboBoxFuncion.Items.Add("ESCALON");
                comboBoxRegla.Items.Add("REGLA DELTA");
            }
            else if (comboBoxTipoDeRed.Text.ToUpper().Equals("ADALINE"))
            {
                comboBoxFuncion.Items.Clear();
                comboBoxRegla.Items.Clear();
                comboBoxFuncion.Items.Add("LINEAL");
                comboBoxRegla.Items.Add("REGLA DELTA");
            }
            else if (comboBoxTipoDeRed.Text.ToUpper().Equals("BACKPROPAGATION"))
            {
                comboBoxFuncion.Items.Clear();
                comboBoxRegla.Items.Clear();
                comboBoxFuncion.Items.Add("SIGMOIDE");
                comboBoxFuncion.Items.Add("TANGENTE HIPERBOLICA");
                comboBoxRegla.Items.Add("PROPAGACION INVERSA");
            }
        }

        string ruta;
        private void buttonMontarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ruta = openFile.FileName;
                Leer(ruta);
            }
            else
            {
                MessageBox.Show("No Se Pudo Cargar El Archivo");
            }
        }

        private void CalcularElErrorDeLaIteracion()
        {
            double suma = 0;
            for (int i = 0; i < Patrones; i++)
            {
                suma = sumar[i] + suma;
            }

            suma = suma / Convert.ToDouble(labelPatrones.Text);

            for (int i = 0; i < Convert.ToInt32(textBoxNIteraciones.Text); i++)
            {
                if (sumar[i].ToString().Equals(""))
                {
                    ErrorIteracion[i] = suma;
                }
            }
        }

        private void ModificarPesosyUmbrales()
        {
            double[,] matriz = new double[Salidas, Entradas];
            double[] umbral = new double[Salidas];
            for (int i = 0; i < Salidas; i++)
            {
                for (int j = 0; j < Entradas; j++)
                {
                    matriz[i, j] = Pesos[i, j] + (Convert.ToDouble(textBoxRata.Text) * ErrorLineal[i] * escalonF[i]);
                    umbral[i] = Umbral[i] + (Convert.ToDouble(textBoxRata.Text) * ErrorLineal[i] * 1);
                }
            }
            Guardar(matriz, umbral);
        }

        private void ErrorLinealProducidoAlaSalida()
        {
            ErrorLineal = new double[Salidas];
            for (int i = 0; i < Salidas; i++)
            {
                ErrorLineal[i] = salidas[i] - escalonF[i];
            }
        }

        private void CalularErrorProducidoEnElPatron()
        {
            sumar = new double[Patrones];
            double suma = 0;
            for (int i = 0; i < Salidas; i++)
            {
                suma = ErrorLineal[i] + suma;
            }

            suma = suma / Convert.ToDouble(label2.Text);

            for (int i = 0; i < Patrones; i++)
            {
                if (sumar[i].ToString().Equals(""))
                {
                    sumar[i] = suma;
                    i = Salidas;
                }
            }
        }

        private void Escalon()
        {
            double[] valor = CalcularSoma();
            double[] escalon = new double[Salidas];
            for (int i = 0; i < Salidas; i++)
            {
                if (valor[i] >= 0)
                {
                    escalon[i] = 1;
                } else if (valor[i] < 0)
                {
                    escalon[i] = 0;
                }
            }
            escalonF = escalon;
        }

        private double[] CalcularSoma()
        {
            double[] valor = new double[Salidas];
            for (int i = 0; i < Salidas; i++)
            {
                valor[i] = 0;
                for (int j = 0; j < Entradas; j++)
                {
                    valor[i] += Convert.ToDouble(entradas[j]) * Pesos[i, j];
                }
                valor[i] += Umbral[i];
            }
            return valor;
        }

        int Entradas = 0, Salidas = 0, Patrones = 0;
        double[,] Pesos;
        double[] Umbral;
        double[] entradas;
        double[] salidas;
        double[] escalonF;
        double[] ErrorLineal;
        double[] sumar;
        double[] ErrorIteracion;
        int CantidadPatrones = 0;
        private void buttonPesosYUmbrales_Click(object sender, EventArgs e)
        {

            double[,] matriz = new double[Salidas, Entradas];
            double[] umbral = new double[Salidas];
            if (label1.Text != "0" && label2.Text != "0")
            {
                for (int i = 0; i < Salidas; i++)
                {
                    for (int j = 0; j < Entradas; j++)
                    {
                        matriz[i, j] = GenerarRamdon();
                        umbral[i] = GenerarRamdon();
                        //MessageBox.Show("POSICION DE LA MATRIZ " + i + "," + j + " = " + matriz[j, i]);
                    }
                    // MessageBox.Show("POSICION DEL UMBRAL " + i + " = " + umbral[i]);
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar El Archivo Primero");
            }
            Pesos = matriz;
            Umbral = umbral;
            Guardar(matriz, umbral);
        }

        private void Guardar(double[,] ma, double[] u)
        {
            configService.Guardar(GuardarBancoConfig());
            matrizService.Guardar(ma, u, Entradas, Salidas);
           // MessageBox.Show(configService.Guardar(GuardarBancoConfig()));
           // MessageBox.Show(matrizService.Guardar(ma, u, Entradas, Salidas));
        }

        private BancoConfig GuardarBancoConfig()
        {
            BancoConfig banco = new BancoConfig(Convert.ToString(Entradas), Convert.ToString(Salidas), Convert.ToString(Patrones), comboBoxDefinir.Text, comboBoxTipoDeRed.Text, comboBoxFuncion.Text, comboBoxRegla.Text);
            return banco;
        }

        private void comboBoxDefinir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDefinir.Text.Equals("UNICAPA"))
            {
                comboBoxFuncion.Items.Clear();
                comboBoxRegla.Items.Clear();
                comboBoxTipoDeRed.Items.Clear();

                comboBoxTipoDeRed.Items.Add("PERCEPTRON");
                comboBoxTipoDeRed.Items.Add("ADALINE");
                comboBoxTipoDeRed.Items.Add("BACKPROPAGATION");

                comboBoxFuncion.Enabled = true;
                comboBoxRegla.Enabled = true;
                comboBoxTipoDeRed.Enabled = true;
                comboBoxCapas.Enabled = false;
            }
            else if (comboBoxDefinir.Text.Equals("MULTICAPA"))
            {
                comboBoxFuncion.Enabled = false;
                comboBoxRegla.Enabled = false;
                comboBoxTipoDeRed.Enabled = false;
                comboBoxCapas.Enabled = true;
                MULTICAPA();
            }
        }

        private void MULTICAPA()
        {
        }

        private void comboBoxTipoDeRed_SelectedIndexChanged(object sender, EventArgs e)
        {
            UNICAPA();
        }

        private void CalculosPorPatron()
        {
            for (int i = 0; i < Convert.ToInt32(labelPatrones.Text); i++)
            {
                if (comboBoxFuncion.Text.Equals("ESCALON"))
                {
                    LLenarEntradasySalidas();
                    Escalon();
                    ErrorLinealProducidoAlaSalida();
                    CalularErrorProducidoEnElPatron();
                    ModificarPesosyUmbrales();
                }
            }
        }
        private void buttonEntrenamiento_Click(object sender, EventArgs e)
        {
            int n = 0;
            for (int i = 0; i < Convert.ToInt32(textBoxNIteraciones.Text); i++)
            {
                CalculosPorPatron();
                CalcularElErrorDeLaIteracion();
                Graficar();
                n++;
            }
            MessageBox.Show(Convert.ToString(n));
        }

        private double GenerarRamdon()
        {
            Random r = new Random();
            double valor = r.Next(-10, 11);
            return valor / 10;

        }

        public void Leer(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {

                Entradas = linea.Split('|').Length - 1;
                Salidas = linea.Split(';').Length - 1;
                Patrones++;
            }

            label1.Text = Convert.ToString(Entradas);
            label2.Text = Convert.ToString(Salidas - 1);
            labelPatrones.Text = Convert.ToString(Patrones);
        }

        private void Graficar()
        {
            ErrorIteracion = new double[Convert.ToInt32(textBoxNIteraciones.Text)];
            chart1.Palette = ChartColorPalette.Pastel;
            chart1.Titles.Add("GRAFICA");
            for (int i = 0; i < ErrorIteracion.Length; i++)
            {
                Series serie = chart1.Series.Add("Iteracion " + i);
                serie.Points.Add(Convert.ToDouble(ErrorIteracion[i]));
            }
        }

        private void LLenarEntradasySalidas()
        {
            entradas = new double[Entradas];
            salidas = new double[Salidas];
            bool bandera = true;
            FileStream file = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                if (CantidadPatrones < Convert.ToInt32(labelPatrones.Text) && bandera == true)
                {
                    AsignarEntradasySalida(linea);
                    bandera = false;
                }
            }
            CantidadPatrones++;
        }

        private void AsignarEntradasySalida(string linea)
        {
            for (int i = 0; i < Entradas; i++)
            {
                entradas[i] = Convert.ToDouble(linea.Split('|')[i]);
            }
           
            for (int j = 1; j < Salidas; j++)
            {
                salidas[j] = Convert.ToDouble(linea.Split(';')[j]); 
            }
        }
    }
}
