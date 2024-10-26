namespace Using_library
{
    partial class Winicio
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
            this.cmdCrear = new System.Windows.Forms.Button();
            this.lblColumnas = new System.Windows.Forms.Label();
            this.txtcolumnas = new System.Windows.Forms.TextBox();
            this.dtgvmatriz = new System.Windows.Forms.DataGridView();
            this.txtfilas = new System.Windows.Forms.TextBox();
            this.lblfilas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvmatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCrear
            // 
            this.cmdCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCrear.Location = new System.Drawing.Point(58, 257);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(80, 61);
            this.cmdCrear.TabIndex = 5;
            this.cmdCrear.Text = "Crear Matriz";
            this.cmdCrear.UseVisualStyleBackColor = true;
            this.cmdCrear.Click += new System.EventHandler(this.cmdCrear_Click);
            // 
            // lblColumnas
            // 
            this.lblColumnas.AutoSize = true;
            this.lblColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnas.Location = new System.Drawing.Point(54, 70);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.Size = new System.Drawing.Size(80, 20);
            this.lblColumnas.TabIndex = 1;
            this.lblColumnas.Text = "Columnas";
            // 
            // txtcolumnas
            // 
            this.txtcolumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcolumnas.Location = new System.Drawing.Point(58, 93);
            this.txtcolumnas.Name = "txtcolumnas";
            this.txtcolumnas.Size = new System.Drawing.Size(100, 26);
            this.txtcolumnas.TabIndex = 2;
            // 
            // dtgvmatriz
            // 
            this.dtgvmatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvmatriz.Location = new System.Drawing.Point(252, 70);
            this.dtgvmatriz.Name = "dtgvmatriz";
            this.dtgvmatriz.Size = new System.Drawing.Size(339, 289);
            this.dtgvmatriz.TabIndex = 6;
            // 
            // txtfilas
            // 
            this.txtfilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfilas.Location = new System.Drawing.Point(58, 158);
            this.txtfilas.Name = "txtfilas";
            this.txtfilas.Size = new System.Drawing.Size(100, 26);
            this.txtfilas.TabIndex = 4;
            // 
            // lblfilas
            // 
            this.lblfilas.AutoSize = true;
            this.lblfilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilas.Location = new System.Drawing.Point(54, 135);
            this.lblfilas.Name = "lblfilas";
            this.lblfilas.Size = new System.Drawing.Size(42, 20);
            this.lblfilas.TabIndex = 3;
            this.lblfilas.Text = "Filas";
            // 
            // Winicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.txtfilas);
            this.Controls.Add(this.lblfilas);
            this.Controls.Add(this.dtgvmatriz);
            this.Controls.Add(this.txtcolumnas);
            this.Controls.Add(this.lblColumnas);
            this.Controls.Add(this.cmdCrear);
            this.Name = "Winicio";
            this.Text = "inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvmatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.Label lblColumnas;
        private System.Windows.Forms.TextBox txtcolumnas;
        private System.Windows.Forms.DataGridView dtgvmatriz;
        private System.Windows.Forms.TextBox txtfilas;
        private System.Windows.Forms.Label lblfilas;
    }
}

