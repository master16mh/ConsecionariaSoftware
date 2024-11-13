namespace ConsecionariaSoftware.FE
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
            this.botonAgregar = new System.Windows.Forms.Button();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.botonEliminarAutos = new System.Windows.Forms.Button();
            this.botonEliminarCamioneta = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridAutos = new System.Windows.Forms.DataGridView();
            this.dataGridCamionetas = new System.Windows.Forms.DataGridView();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxTraccion = new System.Windows.Forms.TextBox();
            this.textBoxCilindrada = new System.Windows.Forms.TextBox();
            this.textBoxCondicion = new System.Windows.Forms.TextBox();
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCamionetas)).BeginInit();
            this.SuspendLayout();
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(27, 209);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 3;
            this.botonAgregar.Text = "Agregar ";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(27, 91);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarca.TabIndex = 8;
            this.textBoxMarca.Text = "Marca";
            // 
            // botonEliminarAutos
            // 
            this.botonEliminarAutos.Location = new System.Drawing.Point(249, 28);
            this.botonEliminarAutos.Name = "botonEliminarAutos";
            this.botonEliminarAutos.Size = new System.Drawing.Size(75, 23);
            this.botonEliminarAutos.TabIndex = 9;
            this.botonEliminarAutos.Text = "Eliminar";
            this.botonEliminarAutos.UseVisualStyleBackColor = true;
            this.botonEliminarAutos.Click += new System.EventHandler(this.botonEliminarAutos_Click);
            // 
            // botonEliminarCamioneta
            // 
            this.botonEliminarCamioneta.Location = new System.Drawing.Point(249, 226);
            this.botonEliminarCamioneta.Name = "botonEliminarCamioneta";
            this.botonEliminarCamioneta.Size = new System.Drawing.Size(75, 23);
            this.botonEliminarCamioneta.TabIndex = 10;
            this.botonEliminarCamioneta.Text = "Eliminar";
            this.botonEliminarCamioneta.UseVisualStyleBackColor = true;
            this.botonEliminarCamioneta.Click += new System.EventHandler(this.botonEliminarCamioneta_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Auto",
            "Camioneta"});
            this.comboBox1.Location = new System.Drawing.Point(27, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridAutos
            // 
            this.dataGridAutos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridAutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAutos.Location = new System.Drawing.Point(342, 28);
            this.dataGridAutos.Name = "dataGridAutos";
            this.dataGridAutos.Size = new System.Drawing.Size(446, 150);
            this.dataGridAutos.TabIndex = 13;
            this.dataGridAutos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAutos_CellEnter);
            // 
            // dataGridCamionetas
            // 
            this.dataGridCamionetas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridCamionetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCamionetas.Location = new System.Drawing.Point(342, 226);
            this.dataGridCamionetas.Name = "dataGridCamionetas";
            this.dataGridCamionetas.Size = new System.Drawing.Size(446, 150);
            this.dataGridCamionetas.TabIndex = 14;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(133, 91);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(100, 20);
            this.textBoxModelo.TabIndex = 15;
            this.textBoxModelo.Text = "Modelo";
            // 
            // textBoxTraccion
            // 
            this.textBoxTraccion.Location = new System.Drawing.Point(27, 117);
            this.textBoxTraccion.Name = "textBoxTraccion";
            this.textBoxTraccion.Size = new System.Drawing.Size(100, 20);
            this.textBoxTraccion.TabIndex = 16;
            this.textBoxTraccion.Text = "Traccion";
            // 
            // textBoxCilindrada
            // 
            this.textBoxCilindrada.Location = new System.Drawing.Point(133, 117);
            this.textBoxCilindrada.Name = "textBoxCilindrada";
            this.textBoxCilindrada.Size = new System.Drawing.Size(100, 20);
            this.textBoxCilindrada.TabIndex = 17;
            this.textBoxCilindrada.Text = "Cilindrada";
            // 
            // textBoxCondicion
            // 
            this.textBoxCondicion.Location = new System.Drawing.Point(27, 143);
            this.textBoxCondicion.Name = "textBoxCondicion";
            this.textBoxCondicion.Size = new System.Drawing.Size(100, 20);
            this.textBoxCondicion.TabIndex = 18;
            this.textBoxCondicion.Text = "Condicion";
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.Location = new System.Drawing.Point(133, 143);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.Size = new System.Drawing.Size(100, 20);
            this.textBoxVersion.TabIndex = 19;
            this.textBoxVersion.Text = "Version";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(27, 169);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecio.TabIndex = 20;
            this.textBoxPrecio.Text = "Precio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxVersion);
            this.Controls.Add(this.textBoxCondicion);
            this.Controls.Add(this.textBoxCilindrada);
            this.Controls.Add(this.textBoxTraccion);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.dataGridCamionetas);
            this.Controls.Add(this.dataGridAutos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.botonEliminarCamioneta);
            this.Controls.Add(this.botonEliminarAutos);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.botonAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCamionetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Button botonEliminarAutos;
        private System.Windows.Forms.Button botonEliminarCamioneta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridAutos;
        private System.Windows.Forms.DataGridView dataGridCamionetas;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxTraccion;
        private System.Windows.Forms.TextBox textBoxCilindrada;
        private System.Windows.Forms.TextBox textBoxCondicion;
        private System.Windows.Forms.TextBox textBoxVersion;
        private System.Windows.Forms.TextBox textBoxPrecio;
    }
}

