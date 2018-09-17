namespace ConvertirJSONaObjetos
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
            this.btnMOSTRAR = new System.Windows.Forms.Button();
            this.dgvJSON = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJSON)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMOSTRAR
            // 
            this.btnMOSTRAR.Location = new System.Drawing.Point(12, 12);
            this.btnMOSTRAR.Name = "btnMOSTRAR";
            this.btnMOSTRAR.Size = new System.Drawing.Size(75, 23);
            this.btnMOSTRAR.TabIndex = 0;
            this.btnMOSTRAR.Text = "Mostrar JSON ";
            this.btnMOSTRAR.UseVisualStyleBackColor = true;
            this.btnMOSTRAR.Click += new System.EventHandler(this.btnMOSTRAR_Click);
            // 
            // dgvJSON
            // 
            this.dgvJSON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJSON.Location = new System.Drawing.Point(12, 69);
            this.dgvJSON.Name = "dgvJSON";
            this.dgvJSON.Size = new System.Drawing.Size(642, 150);
            this.dgvJSON.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 263);
            this.Controls.Add(this.dgvJSON);
            this.Controls.Add(this.btnMOSTRAR);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJSON)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMOSTRAR;
        private System.Windows.Forms.DataGridView dgvJSON;
    }
}

