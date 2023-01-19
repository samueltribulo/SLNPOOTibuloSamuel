namespace WindowsEFDatos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminarAvion = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregarAvion = new System.Windows.Forms.Button();
            this.btnBuscarPorId = new System.Windows.Forms.Button();
            this.labelCapacidad = new System.Windows.Forms.Label();
            this.textBoxCapacidad = new System.Windows.Forms.TextBox();
            this.textBoxDenominacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(90, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnEliminarAvion
            // 
            this.btnEliminarAvion.Location = new System.Drawing.Point(553, 52);
            this.btnEliminarAvion.Name = "btnEliminarAvion";
            this.btnEliminarAvion.Size = new System.Drawing.Size(134, 52);
            this.btnEliminarAvion.TabIndex = 1;
            this.btnEliminarAvion.Text = "Eliminar avión";
            this.btnEliminarAvion.UseVisualStyleBackColor = true;
            this.btnEliminarAvion.Click += new System.EventHandler(this.btnEliminarAvion_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(553, 143);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(134, 52);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar avión";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregarAvion
            // 
            this.btnAgregarAvion.Location = new System.Drawing.Point(384, 52);
            this.btnAgregarAvion.Name = "btnAgregarAvion";
            this.btnAgregarAvion.Size = new System.Drawing.Size(134, 52);
            this.btnAgregarAvion.TabIndex = 3;
            this.btnAgregarAvion.Text = "Agregar avión";
            this.btnAgregarAvion.UseVisualStyleBackColor = true;
            this.btnAgregarAvion.Click += new System.EventHandler(this.btnAgregarAvion_Click);
            // 
            // btnBuscarPorId
            // 
            this.btnBuscarPorId.Location = new System.Drawing.Point(384, 143);
            this.btnBuscarPorId.Name = "btnBuscarPorId";
            this.btnBuscarPorId.Size = new System.Drawing.Size(134, 52);
            this.btnBuscarPorId.TabIndex = 4;
            this.btnBuscarPorId.Text = "Buscar por id";
            this.btnBuscarPorId.UseVisualStyleBackColor = true;
            this.btnBuscarPorId.Click += new System.EventHandler(this.btnBuscarPorId_Click);
            // 
            // labelCapacidad
            // 
            this.labelCapacidad.AutoSize = true;
            this.labelCapacidad.Location = new System.Drawing.Point(86, 87);
            this.labelCapacidad.Name = "labelCapacidad";
            this.labelCapacidad.Size = new System.Drawing.Size(58, 13);
            this.labelCapacidad.TabIndex = 5;
            this.labelCapacidad.Text = "Capacidad";
            // 
            // textBoxCapacidad
            // 
            this.textBoxCapacidad.Location = new System.Drawing.Point(150, 84);
            this.textBoxCapacidad.Name = "textBoxCapacidad";
            this.textBoxCapacidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCapacidad.TabIndex = 6;
            // 
            // textBoxDenominacion
            // 
            this.textBoxDenominacion.Location = new System.Drawing.Point(150, 125);
            this.textBoxDenominacion.Name = "textBoxDenominacion";
            this.textBoxDenominacion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDenominacion.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Denominación";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(128, 167);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 10;
            this.labelId.Text = "Id";
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(150, 165);
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownId.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDenominacion);
            this.Controls.Add(this.textBoxCapacidad);
            this.Controls.Add(this.labelCapacidad);
            this.Controls.Add(this.btnBuscarPorId);
            this.Controls.Add(this.btnAgregarAvion);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarAvion);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminarAvion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregarAvion;
        private System.Windows.Forms.Button btnBuscarPorId;
        private System.Windows.Forms.Label labelCapacidad;
        private System.Windows.Forms.TextBox textBoxCapacidad;
        private System.Windows.Forms.TextBox textBoxDenominacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.NumericUpDown numericUpDownId;
    }
}

