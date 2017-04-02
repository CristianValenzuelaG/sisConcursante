namespace sisConcurso.Vista
{
    partial class frmMainMunicipio
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
            this.label1 = new System.Windows.Forms.Label();
            this.grDatos = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.mNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDescripion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mLogotipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // grDatos
            // 
            this.grDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mNombre,
            this.mDescripion,
            this.mLogotipo});
            this.grDatos.Location = new System.Drawing.Point(12, 44);
            this.grDatos.Name = "grDatos";
            this.grDatos.Size = new System.Drawing.Size(447, 259);
            this.grDatos.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(376, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 355);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 35);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 355);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(84, 35);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(183, 355);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 35);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(384, 355);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 35);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(408, 306);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(51, 20);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "label2";
            // 
            // mNombre
            // 
            this.mNombre.DataPropertyName = "mNombre";
            this.mNombre.HeaderText = "Nombre";
            this.mNombre.Name = "mNombre";
            this.mNombre.Width = 150;
            // 
            // mDescripion
            // 
            this.mDescripion.DataPropertyName = "mDescripion";
            this.mDescripion.HeaderText = "Descripcion";
            this.mDescripion.Name = "mDescripion";
            this.mDescripion.Width = 150;
            // 
            // mLogotipo
            // 
            this.mLogotipo.DataPropertyName = "mLogotipo";
            this.mLogotipo.HeaderText = "Logotipo";
            this.mLogotipo.Name = "mLogotipo";
            // 
            // frmMainMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 402);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.grDatos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainMunicipio";
            this.Text = "frmMainMunicipio";
            this.Load += new System.EventHandler(this.frmMainMunicipio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grDatos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDescripion;
        private System.Windows.Forms.DataGridViewTextBoxColumn mLogotipo;
    }
}