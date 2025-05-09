namespace olamuchogusto
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
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.Most = new System.Windows.Forms.Button();
            this.Exp = new System.Windows.Forms.Button();
            this.Imp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDatos
            // 
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Location = new System.Drawing.Point(99, 53);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.Size = new System.Drawing.Size(635, 261);
            this.dgDatos.TabIndex = 0;
            // 
            // Most
            // 
            this.Most.Location = new System.Drawing.Point(130, 372);
            this.Most.Name = "Most";
            this.Most.Size = new System.Drawing.Size(126, 31);
            this.Most.TabIndex = 1;
            this.Most.Text = "Mostrar";
            this.Most.UseVisualStyleBackColor = true;
            this.Most.Click += new System.EventHandler(this.Most_Click);
            // 
            // Exp
            // 
            this.Exp.Location = new System.Drawing.Point(518, 375);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(150, 27);
            this.Exp.TabIndex = 2;
            this.Exp.Text = "Exportar";
            this.Exp.UseVisualStyleBackColor = true;
            this.Exp.Click += new System.EventHandler(this.Exp_Click);
            // 
            // Imp
            // 
            this.Imp.Location = new System.Drawing.Point(328, 379);
            this.Imp.Name = "Imp";
            this.Imp.Size = new System.Drawing.Size(133, 23);
            this.Imp.TabIndex = 3;
            this.Imp.Text = "Importar";
            this.Imp.UseVisualStyleBackColor = true;
            this.Imp.Click += new System.EventHandler(this.Imp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Imp);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.Most);
            this.Controls.Add(this.dgDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.Button Most;
        private System.Windows.Forms.Button Exp;
        private System.Windows.Forms.Button Imp;
    }
}

