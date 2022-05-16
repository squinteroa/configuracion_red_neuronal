
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
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTipoDeRed
            // 
            this.comboBoxTipoDeRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTipoDeRed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoDeRed.FormattingEnabled = true;
            this.comboBoxTipoDeRed.Items.AddRange(new object[] {
            "PERCEPTRON",
            "ADALINE",
            "BACKPROPAGATION"});
            this.comboBoxTipoDeRed.Location = new System.Drawing.Point(137, 48);
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
            this.labelTipoDeRed.Location = new System.Drawing.Point(12, 44);
            this.labelTipoDeRed.Name = "labelTipoDeRed";
            this.labelTipoDeRed.Size = new System.Drawing.Size(119, 22);
            this.labelTipoDeRed.TabIndex = 100;
            this.labelTipoDeRed.Text = "Tipo De Red";
            // 
            // comboBoxFuncion
            // 
            this.comboBoxFuncion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuncion.FormattingEnabled = true;
            this.comboBoxFuncion.Location = new System.Drawing.Point(238, 116);
            this.comboBoxFuncion.Name = "comboBoxFuncion";
            this.comboBoxFuncion.Size = new System.Drawing.Size(144, 21);
            this.comboBoxFuncion.TabIndex = 103;
            this.comboBoxFuncion.SelectedIndexChanged += new System.EventHandler(this.comboBoxFuncion_SelectedIndexChanged);
            // 
            // labelFuncion
            // 
            this.labelFuncion.AutoSize = true;
            this.labelFuncion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuncion.ForeColor = System.Drawing.Color.Black;
            this.labelFuncion.Location = new System.Drawing.Point(12, 116);
            this.labelFuncion.Name = "labelFuncion";
            this.labelFuncion.Size = new System.Drawing.Size(220, 22);
            this.labelFuncion.TabIndex = 102;
            this.labelFuncion.Text = "Funcion De Activacion";
            // 
            // comboBoxRegla
            // 
            this.comboBoxRegla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxRegla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegla.FormattingEnabled = true;
            this.comboBoxRegla.Location = new System.Drawing.Point(238, 178);
            this.comboBoxRegla.Name = "comboBoxRegla";
            this.comboBoxRegla.Size = new System.Drawing.Size(144, 21);
            this.comboBoxRegla.TabIndex = 105;
            this.comboBoxRegla.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegla_SelectedIndexChanged);
            // 
            // labelRegla
            // 
            this.labelRegla.AutoSize = true;
            this.labelRegla.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegla.ForeColor = System.Drawing.Color.Black;
            this.labelRegla.Location = new System.Drawing.Point(12, 178);
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
            this.buttonMontarArchivo.Location = new System.Drawing.Point(16, 242);
            this.buttonMontarArchivo.Name = "buttonMontarArchivo";
            this.buttonMontarArchivo.Size = new System.Drawing.Size(178, 40);
            this.buttonMontarArchivo.TabIndex = 119;
            this.buttonMontarArchivo.Text = "MONTAR ARCHIVO";
            this.buttonMontarArchivo.UseVisualStyleBackColor = false;
            this.buttonMontarArchivo.Click += new System.EventHandler(this.buttonMontarArchivo_Click);
            // 
            // labelEntrada
            // 
            this.labelEntrada.AutoSize = true;
            this.labelEntrada.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntrada.ForeColor = System.Drawing.Color.Black;
            this.labelEntrada.Location = new System.Drawing.Point(12, 335);
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
            this.labelSalida.Location = new System.Drawing.Point(12, 373);
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
            this.labelRegistros.Location = new System.Drawing.Point(12, 410);
            this.labelRegistros.Name = "labelRegistros";
            this.labelRegistros.Size = new System.Drawing.Size(82, 22);
            this.labelRegistros.TabIndex = 122;
            this.labelRegistros.Text = "Registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 125;
            this.label3.Text = "label3";
            // 
            // FromUnicapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 527);
            this.Controls.Add(this.label3);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label label3;
    }
}