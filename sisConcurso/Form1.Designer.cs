namespace sisConcurso
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
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.btConcursante = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            this.SuspendLayout();
            // 
            // pct1
            // 
            this.pct1.Image = global::sisConcurso.Properties.Resources.fondo;
            this.pct1.Location = new System.Drawing.Point(0, -3);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(646, 464);
            this.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct1.TabIndex = 1;
            this.pct1.TabStop = false;
            // 
            // btConcursante
            // 
            this.btConcursante.Location = new System.Drawing.Point(33, 57);
            this.btConcursante.Name = "btConcursante";
            this.btConcursante.Size = new System.Drawing.Size(110, 39);
            this.btConcursante.TabIndex = 2;
            this.btConcursante.Text = "Concursante";
            this.btConcursante.UseVisualStyleBackColor = true;
            this.btConcursante.Click += new System.EventHandler(this.btConcursante_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Municipio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btConcursante);
            this.Controls.Add(this.pct1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Concurso";
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pct1;
        private System.Windows.Forms.Button btConcursante;
        private System.Windows.Forms.Button button2;
    }
}

