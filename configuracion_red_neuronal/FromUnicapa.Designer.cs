
namespace configuracion_red_neuronal
{
    partial class FromUnicapa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxTipoDeRed = new System.Windows.Forms.ComboBox();
            this.labelTipoDeRed = new System.Windows.Forms.Label();
            this.comboBoxFuncion = new System.Windows.Forms.ComboBox();
            this.labelFuncion = new System.Windows.Forms.Label();
            this.comboBoxRegla = new System.Windows.Forms.ComboBox();
            this.labelRegla = new System.Windows.Forms.Label();
            this.buttonMontarArchivo = new System.Windows.Forms.Button();
            this.labelEntrada = new System.Windows.Forms.Label();
            this.labelSalida = new System.Windows.Forms.Label();
            this.labelRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPatrones = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonPesosYUmbrales = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNIteraciones = new System.Windows.Forms.TextBox();
            this.textBoxErrorMaximoPermitido = new System.Windows.Forms.TextBox();
            this.textBoxRata = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonEntrenamiento = new System.Windows.Forms.Button();
            this.comboBoxDefinir = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCapas = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTipoDeRed
            // 
            this.comboBoxTipoDeRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTipoDeRed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoDeRed.Enabled = false;
            this.comboBoxTipoDeRed.FormattingEnabled = true;
            this.comboBoxTipoDeRed.Location = new System.Drawing.Point(147, 300);
            this.comboBoxTipoDeRed.Name = "comboBoxTipoDeRed";
            this.comboBoxTipoDeRed.Size = new System.Drawing.Size(144, 21);
            this.comboBoxTipoDeRed.TabIndex = 101;
            this.comboBoxTipoDeRed.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoDeRed_SelectedIndexChanged);
            // 
            // labelTipoDeRed
            // 
            this.labelTipoDeRed.AutoSize = true;
            this.labelTipoDeRed.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoDeRed.ForeColor = System.Drawing.Color.Black;
            this.labelTipoDeRed.Location = new System.Drawing.Point(22, 296);
            this.labelTipoDeRed.Name = "labelTipoDeRed";
            this.labelTipoDeRed.Size = new System.Drawing.Size(119, 22);
            this.labelTipoDeRed.TabIndex = 100;
            this.labelTipoDeRed.Text = "Tipo De Red";
            // 
            // comboBoxFuncion
            // 
            this.comboBoxFuncion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuncion.Enabled = false;
            this.comboBoxFuncion.FormattingEnabled = true;
            this.comboBoxFuncion.Location = new System.Drawing.Point(248, 333);
            this.comboBoxFuncion.Name = "comboBoxFuncion";
            this.comboBoxFuncion.Size = new System.Drawing.Size(144, 21);
            this.comboBoxFuncion.TabIndex = 103;
            // 
            // labelFuncion
            // 
            this.labelFuncion.AutoSize = true;
            this.labelFuncion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuncion.ForeColor = System.Drawing.Color.Black;
            this.labelFuncion.Location = new System.Drawing.Point(22, 333);
            this.labelFuncion.Name = "labelFuncion";
            this.labelFuncion.Size = new System.Drawing.Size(220, 22);
            this.labelFuncion.TabIndex = 102;
            this.labelFuncion.Text = "Funcion De Activacion";
            // 
            // comboBoxRegla
            // 
            this.comboBoxRegla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxRegla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegla.Enabled = false;
            this.comboBoxRegla.FormattingEnabled = true;
            this.comboBoxRegla.Location = new System.Drawing.Point(248, 369);
            this.comboBoxRegla.Name = "comboBoxRegla";
            this.comboBoxRegla.Size = new System.Drawing.Size(144, 21);
            this.comboBoxRegla.TabIndex = 105;
            // 
            // labelRegla
            // 
            this.labelRegla.AutoSize = true;
            this.labelRegla.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegla.ForeColor = System.Drawing.Color.Black;
            this.labelRegla.Location = new System.Drawing.Point(22, 369);
            this.labelRegla.Name = "labelRegla";
            this.labelRegla.Size = new System.Drawing.Size(210, 22);
            this.labelRegla.TabIndex = 104;
            this.labelRegla.Text = "Regla De Entramiento";
            // 
            // buttonMontarArchivo
            // 
            this.buttonMontarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMontarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonMontarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMontarArchivo.FlatAppearance.BorderSize = 0;
            this.buttonMontarArchivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonMontarArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMontarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMontarArchivo.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMontarArchivo.Location = new System.Drawing.Point(26, 50);
            this.buttonMontarArchivo.Name = "buttonMontarArchivo";
            this.buttonMontarArchivo.Size = new System.Drawing.Size(178, 40);
            this.buttonMontarArchivo.TabIndex = 119;
            this.buttonMontarArchivo.Text = "LEER ARCHIVO";
            this.buttonMontarArchivo.UseVisualStyleBackColor = false;
            this.buttonMontarArchivo.Click += new System.EventHandler(this.buttonMontarArchivo_Click);
            // 
            // labelEntrada
            // 
            this.labelEntrada.AutoSize = true;
            this.labelEntrada.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntrada.ForeColor = System.Drawing.Color.Black;
            this.labelEntrada.Location = new System.Drawing.Point(22, 105);
            this.labelEntrada.Name = "labelEntrada";
            this.labelEntrada.Size = new System.Drawing.Size(91, 22);
            this.labelEntrada.TabIndex = 120;
            this.labelEntrada.Text = "Entradas";
            // 
            // labelSalida
            // 
            this.labelSalida.AutoSize = true;
            this.labelSalida.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalida.ForeColor = System.Drawing.Color.Black;
            this.labelSalida.Location = new System.Drawing.Point(22, 143);
            this.labelSalida.Name = "labelSalida";
            this.labelSalida.Size = new System.Drawing.Size(64, 22);
            this.labelSalida.TabIndex = 121;
            this.labelSalida.Text = "Salida";
            // 
            // labelRegistros
            // 
            this.labelRegistros.AutoSize = true;
            this.labelRegistros.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistros.ForeColor = System.Drawing.Color.Black;
            this.labelRegistros.Location = new System.Drawing.Point(22, 180);
            this.labelRegistros.Name = "labelRegistros";
            this.labelRegistros.Size = new System.Drawing.Size(90, 22);
            this.labelRegistros.TabIndex = 122;
            this.labelRegistros.Text = "Patrones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "0";
            // 
            // labelPatrones
            // 
            this.labelPatrones.AutoSize = true;
            this.labelPatrones.Location = new System.Drawing.Point(119, 187);
            this.labelPatrones.Name = "labelPatrones";
            this.labelPatrones.Size = new System.Drawing.Size(13, 13);
            this.labelPatrones.TabIndex = 125;
            this.labelPatrones.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 23);
            this.label4.TabIndex = 126;
            this.label4.Text = "BANCO DE DATOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 23);
            this.label5.TabIndex = 127;
            this.label5.Text = "CONFIGURACION DE LA RED";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 23);
            this.label6.TabIndex = 128;
            this.label6.Text = "INICIALIZAR PESOS Y UMBRALES";
            // 
            // buttonPesosYUmbrales
            // 
            this.buttonPesosYUmbrales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPesosYUmbrales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonPesosYUmbrales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPesosYUmbrales.FlatAppearance.BorderSize = 0;
            this.buttonPesosYUmbrales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonPesosYUmbrales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPesosYUmbrales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesosYUmbrales.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPesosYUmbrales.Location = new System.Drawing.Point(26, 490);
            this.buttonPesosYUmbrales.Name = "buttonPesosYUmbrales";
            this.buttonPesosYUmbrales.Size = new System.Drawing.Size(178, 40);
            this.buttonPesosYUmbrales.TabIndex = 129;
            this.buttonPesosYUmbrales.Text = "GENERAR";
            this.buttonPesosYUmbrales.UseVisualStyleBackColor = false;
            this.buttonPesosYUmbrales.Click += new System.EventHandler(this.buttonPesosYUmbrales_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(564, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 23);
            this.label7.TabIndex = 130;
            this.label7.Text = "PARAMETROS DE ENTRADA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(564, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 22);
            this.label8.TabIndex = 133;
            this.label8.Text = "Error Maximo Permitido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(564, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 22);
            this.label9.TabIndex = 132;
            this.label9.Text = "Rata Aprendizaje";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(564, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 22);
            this.label10.TabIndex = 131;
            this.label10.Text = "N° Iteraciones";
            // 
            // textBoxNIteraciones
            // 
            this.textBoxNIteraciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNIteraciones.Location = new System.Drawing.Point(788, 57);
            this.textBoxNIteraciones.Name = "textBoxNIteraciones";
            this.textBoxNIteraciones.Size = new System.Drawing.Size(70, 20);
            this.textBoxNIteraciones.TabIndex = 134;
            // 
            // textBoxErrorMaximoPermitido
            // 
            this.textBoxErrorMaximoPermitido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxErrorMaximoPermitido.Location = new System.Drawing.Point(788, 134);
            this.textBoxErrorMaximoPermitido.Name = "textBoxErrorMaximoPermitido";
            this.textBoxErrorMaximoPermitido.Size = new System.Drawing.Size(70, 20);
            this.textBoxErrorMaximoPermitido.TabIndex = 135;
            // 
            // textBoxRata
            // 
            this.textBoxRata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRata.Location = new System.Drawing.Point(788, 100);
            this.textBoxRata.Name = "textBoxRata";
            this.textBoxRata.Size = new System.Drawing.Size(70, 20);
            this.textBoxRata.TabIndex = 136;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(564, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 23);
            this.label11.TabIndex = 137;
            this.label11.Text = "ENTRENAMIENTO";
            // 
            // buttonEntrenamiento
            // 
            this.buttonEntrenamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEntrenamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonEntrenamiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEntrenamiento.FlatAppearance.BorderSize = 0;
            this.buttonEntrenamiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonEntrenamiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEntrenamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntrenamiento.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEntrenamiento.Location = new System.Drawing.Point(568, 226);
            this.buttonEntrenamiento.Name = "buttonEntrenamiento";
            this.buttonEntrenamiento.Size = new System.Drawing.Size(178, 40);
            this.buttonEntrenamiento.TabIndex = 138;
            this.buttonEntrenamiento.Text = "INICIAR";
            this.buttonEntrenamiento.UseVisualStyleBackColor = false;
            this.buttonEntrenamiento.Click += new System.EventHandler(this.buttonEntrenamiento_Click);
            // 
            // comboBoxDefinir
            // 
            this.comboBoxDefinir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDefinir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDefinir.FormattingEnabled = true;
            this.comboBoxDefinir.Items.AddRange(new object[] {
            "UNICAPA",
            "MULTICAPA"});
            this.comboBoxDefinir.Location = new System.Drawing.Point(147, 269);
            this.comboBoxDefinir.Name = "comboBoxDefinir";
            this.comboBoxDefinir.Size = new System.Drawing.Size(144, 21);
            this.comboBoxDefinir.TabIndex = 140;
            this.comboBoxDefinir.SelectedIndexChanged += new System.EventHandler(this.comboBoxDefinir_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 139;
            this.label3.Text = "Definir Red";
            // 
            // comboBoxCapas
            // 
            this.comboBoxCapas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCapas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCapas.Enabled = false;
            this.comboBoxCapas.FormattingEnabled = true;
            this.comboBoxCapas.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxCapas.Location = new System.Drawing.Point(211, 416);
            this.comboBoxCapas.Name = "comboBoxCapas";
            this.comboBoxCapas.Size = new System.Drawing.Size(144, 21);
            this.comboBoxCapas.TabIndex = 142;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(22, 412);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 22);
            this.label12.TabIndex = 141;
            this.label12.Text = "Capas Intermedias";
            // 
            // FromUnicapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 565);
            this.Controls.Add(this.comboBoxCapas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxDefinir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonEntrenamiento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxRata);
            this.Controls.Add(this.textBoxErrorMaximoPermitido);
            this.Controls.Add(this.textBoxNIteraciones);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonPesosYUmbrales);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPatrones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRegistros);
            this.Controls.Add(this.labelSalida);
            this.Controls.Add(this.labelEntrada);
            this.Controls.Add(this.buttonMontarArchivo);
            this.Controls.Add(this.comboBoxRegla);
            this.Controls.Add(this.labelRegla);
            this.Controls.Add(this.comboBoxFuncion);
            this.Controls.Add(this.labelFuncion);
            this.Controls.Add(this.comboBoxTipoDeRed);
            this.Controls.Add(this.labelTipoDeRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FromUnicapa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxTipoDeRed;
        private System.Windows.Forms.Label labelTipoDeRed;
        public System.Windows.Forms.ComboBox comboBoxFuncion;
        private System.Windows.Forms.Label labelFuncion;
        public System.Windows.Forms.ComboBox comboBoxRegla;
        private System.Windows.Forms.Label labelRegla;
        public System.Windows.Forms.Button buttonMontarArchivo;
        private System.Windows.Forms.Label labelEntrada;
        private System.Windows.Forms.Label labelSalida;
        private System.Windows.Forms.Label labelRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPatrones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button buttonPesosYUmbrales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNIteraciones;
        private System.Windows.Forms.TextBox textBoxErrorMaximoPermitido;
        private System.Windows.Forms.TextBox textBoxRata;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button buttonEntrenamiento;
        public System.Windows.Forms.ComboBox comboBoxDefinir;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBoxCapas;
        private System.Windows.Forms.Label label12;
    }
}