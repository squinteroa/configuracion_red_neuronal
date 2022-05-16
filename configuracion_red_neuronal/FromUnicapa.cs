using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace configuracion_red_neuronal
{
    public partial class FromUnicapa : Form
    {
        public FromUnicapa()
        {
            InitializeComponent();
            buttonMontarArchivo.Enabled = false;
        }

        private void LlenarFuncionDeActivacion()
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

        private void AvilitarBonton()
        {
            if(comboBoxRegla.Text.Equals("") || comboBoxFuncion.Text.Equals(""))
            {
                buttonMontarArchivo.Enabled = false;
            }
            else
            {
                buttonMontarArchivo.Enabled = true;
            }
        }

        private void comboBoxTipoDeRed_SelectedIndexChanged(object sender, EventArgs e)
        {
           LlenarFuncionDeActivacion();
           AvilitarBonton();
        }

        string ruta;
        private void buttonMontarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ruta = openFile.FileName;
               // label1.Text = Leer(ruta);
            }
            else
            {
                MessageBox.Show("No Se Pudo Cargar El Archivo");
            }
        }

        private void comboBoxFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {
            AvilitarBonton();
        }

        private void comboBoxRegla_SelectedIndexChanged(object sender, EventArgs e)
        {
            AvilitarBonton();
        }
    }
}
