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

        private void CalcularElErrorDeLaIteracion(int num)
        {
            double suma = 0;
            for (int i = 0; i < Patrones; i++)
            {
                suma += ErrorPatron[i];
            }

            suma /= Patrones;
            ErrorIteracion[num] = suma;
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

        private void CalularErrorProducidoEnElPatron(int numero)
        {
            double suma = 0;
            for (int i = 0; i < Salidas; i++)
            {
                suma += Math.Abs(ErrorLineal[i]);
            }

            suma /= Salidas;

            ErrorPatron[numero] = suma;
        }

        private void Escalon()
        {
            double[] valor = Soma;
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

        private void CalcularSoma()
        {
            double[] valor = new double[Salidas];
            for (int i = 0; i < Salidas; i++)
            {
                valor[i] = 0;
                for (int j = 0; j < Entradas; j++)
                {
                    valor[i] += Convert.ToDouble(entradas[j]) * Pesos[i, j];
                }
                valor[i] -= Umbral[i];
            }
            Soma = valor;
        }

        int Entradas = 0, Salidas = 0, Patrones = 0;
        double[,] Pesos;
        double[] Umbral;
        double[] entradas;
        double[] salidas;
        double[] escalonF;
        double[] ErrorLineal;
        double[] ErrorPatron;
        double[] ErrorIteracion;
        double[] Soma;
        private void buttonPesosYUmbrales_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            double valor;
            double[,] matriz = new double[Salidas, Entradas];
            double[] umbral = new double[Salidas];
            if (label1.Text != "0" && label2.Text != "0")
            {
                for (int i = 0; i < Salidas; i++)
                {
                    for (int j = 0; j < Entradas; j++)
                    {
                        valor = r.Next(-10, 11);
                        matriz[i, j] = (valor) / 10; 
                    }
                    valor = r.Next(-10, 11);
                    umbral[i] = (valor) / 10;
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
            for (int i = 0; i < Patrones; i++)
            {
                if (comboBoxFuncion.Text.Equals("ESCALON"))
                {
                    LLenarEntradasySalidas(i);
                    CalcularSoma();
                    Escalon();
                    ErrorLinealProducidoAlaSalida();
                    CalularErrorProducidoEnElPatron(i);
                    ModificarPesosyUmbrales();
                    //PruebaValores();
                }
            }
        }
        private void buttonEntrenamiento_Click(object sender, EventArgs e)
        {
            int n = 0;
            for (int i = 0; i < Convert.ToInt32(textBoxNIteraciones.Text); i++)
            {
                CalculosPorPatron();
                CalcularElErrorDeLaIteracion(i);
                n++;
            }
            PruebaErrorIteracion();
            Graficar();
            //MessageBox.Show(Convert.ToString(n));
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
            label2.Text = Convert.ToString(Salidas);
            labelPatrones.Text = Convert.ToString(Patrones);
            ErrorPatron = new double[Patrones];
            ErrorIteracion = new double[Convert.ToInt32(textBoxNIteraciones.Text)];
        }

        private void Graficar()
        {
            chart1.Series.Clear();
            chart1.Palette = ChartColorPalette.Pastel;
            chart1.Titles.Add("GRAFICA");
            for (int i = 0; i < ErrorIteracion.Length; i++)
            {
                Series series1 = chart1.Series.Add("Iteracion " + i);
                series1.Points.Add(Convert.ToDouble(ErrorIteracion[i]));
            }
        }

        private void LLenarEntradasySalidas(int CantidadPatrones)
        {
            int contador = 0;
            entradas = new double[Entradas];
            salidas = new double[Salidas];
            bool bandera = true;
            FileStream file = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                if (CantidadPatrones == contador && bandera == true)
                {
                    AsignarEntradasySalida(linea);
                    bandera = false;
                }
                contador++;
            }
        }

        private void AsignarEntradasySalida(string linea)
        {
            string per;
            for (int i = 0; i < Entradas; i++)
            {
                entradas[i] = Convert.ToDouble(linea.Split('|')[i]);
            }

            for (int j = 0; j < Salidas; j++)
            {
                if (j == 0)
                {
                    String header = Convert.ToString(linea.Split(';')[j]);
                    per = header.Remove(0, (Entradas * 2));
                    try { salidas[j] = Convert.ToDouble(per); } catch { }
                }else if(j > 0)
                {
                    try { salidas[j] = Convert.ToDouble(linea.Split(';')[j]); } catch { }
                }
            }
        }

        private void PruebaValores()
        {
            for (int i = 0; i < entradas.Length; i++)
            {
                MessageBox.Show("Cantidad De Posiciones Entrada: " + i + " Valor: "+Convert.ToString(entradas[i]));
            }

            for (int i = 0; i < salidas.Length; i++)
            {
                MessageBox.Show("Cantidad De Posiciones Salida: " + i + " Valor: " + Convert.ToString(salidas[i]));
            }

            for (int i = 0; i < salidas.Length; i++)
            {
                MessageBox.Show("Cantidad De Posiciones Soma: " + i + " Valor: " + Convert.ToString(Soma[i]));
            }

            for (int i = 0; i < salidas.Length; i++)
            {
                MessageBox.Show("Cantidad De Posiciones Escalon: " + i + " Valor: " + Convert.ToString(escalonF[i]));
            }

            for (int i = 0; i < salidas.Length; i++)
            {
                MessageBox.Show("Cantidad De Posiciones ErrorLineal: " + i + " Valor: " + Convert.ToString(ErrorLineal[i]));
            }

            for (int i = 0; i < Patrones; i++)
            {
                MessageBox.Show("Cantidad De Posiciones ErrorPatron: " + i + " Valor: " + Convert.ToString(ErrorPatron[i]));
            }
        }

        private void PruebaErrorIteracion()
        {
            for (int i = 0; i < Convert.ToInt32(textBoxNIteraciones.Text); i++)
            {
                MessageBox.Show("Cantidad De Posiciones ErrorIteracion: " + i + " Valor: " + Convert.ToString(ErrorIteracion[i]));
            }
        }
    }
}
