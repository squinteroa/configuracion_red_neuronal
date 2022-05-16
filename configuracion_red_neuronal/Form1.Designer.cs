
namespace configuracion_red_neuronal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.buttonUnicapa = new System.Windows.Forms.Button();
            this.buttonMulticapa = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelLateral.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.DarkRed;
            this.panelLateral.Controls.Add(this.pictureBox2);
            this.panelLateral.Controls.Add(this.buttonMulticapa);
            this.panelLateral.Controls.Add(this.buttonUnicapa);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(250, 527);
            this.panelLateral.TabIndex = 102;
            this.panelLateral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(669, 527);
            this.panelContenedor.TabIndex = 103;
            this.panelContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelContenedor_MouseDown);
            // 
            // buttonUnicapa
            // 
            this.buttonUnicapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUnicapa.FlatAppearance.BorderSize = 0;
            this.buttonUnicapa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonUnicapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnicapa.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnicapa.ForeColor = System.Drawing.Color.White;
            this.buttonUnicapa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUnicapa.Location = new System.Drawing.Point(0, 218);
            this.buttonUnicapa.Name = "buttonUnicapa";
            this.buttonUnicapa.Size = new System.Drawing.Size(250, 50);
            this.buttonUnicapa.TabIndex = 5;
            this.buttonUnicapa.Text = "Unicapa";
            this.buttonUnicapa.UseVisualStyleBackColor = true;
            this.buttonUnicapa.Click += new System.EventHandler(this.buttonUnicapa_Click);
            // 
            // buttonMulticapa
            // 
            this.buttonMulticapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMulticapa.FlatAppearance.BorderSize = 0;
            this.buttonMulticapa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonMulticapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMulticapa.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMulticapa.ForeColor = System.Drawing.Color.White;
            this.buttonMulticapa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMulticapa.Location = new System.Drawing.Point(0, 306);
            this.buttonMulticapa.Name = "buttonMulticapa";
            this.buttonMulticapa.Size = new System.Drawing.Size(250, 50);
            this.buttonMulticapa.TabIndex = 102;
            this.buttonMulticapa.Text = "Multicapa";
            this.buttonMulticapa.UseVisualStyleBackColor = true;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSuperior.Controls.Add(this.pictureBoxMinimizar);
            this.panelSuperior.Controls.Add(this.pictureBoxCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(250, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(669, 35);
            this.panelSuperior.TabIndex = 3;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimizar.Image = global::configuracion_red_neuronal.Properties.Resources.icon_minimizar;
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(599, 5);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimizar.TabIndex = 4;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrar.Image = global::configuracion_red_neuronal.Properties.Resources.icon_cerrar2;
            this.pictureBoxCerrar.Location = new System.Drawing.Point(632, 5);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCerrar.TabIndex = 3;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBoxCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::configuracion_red_neuronal.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(72, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::configuracion_red_neuronal.Properties.Resources.cafe;
            this.pictureBox2.Location = new System.Drawing.Point(25, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 103;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 527);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.panelLateral.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button buttonMulticapa;
        private System.Windows.Forms.Button buttonUnicapa;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
    }
}

