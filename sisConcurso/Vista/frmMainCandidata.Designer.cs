namespace sisConcurso.Vista
{
    partial class frmMainCandidata
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.pkCandidata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombreCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCorre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNivelStudio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRaking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
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
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(677, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // grdDatos
            // 
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkCandidata,
            this.cNombreCom,
            this.cFDN,
            this.cDescripcion,
            this.cCorre,
            this.cNivelStudio,
            this.cRaking});
            this.grdDatos.Location = new System.Drawing.Point(13, 42);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.Size = new System.Drawing.Size(812, 309);
            this.grdDatos.TabIndex = 2;
            // 
            // pkCandidata
            // 
            this.pkCandidata.DataPropertyName = "pkCandidata";
            this.pkCandidata.HeaderText = "Id";
            this.pkCandidata.Name = "pkCandidata";
            this.pkCandidata.Width = 55;
            // 
            // cNombreCom
            // 
            this.cNombreCom.DataPropertyName = "cNombreCom";
            this.cNombreCom.HeaderText = "Nombre Completo";
            this.cNombreCom.Name = "cNombreCom";
            this.cNombreCom.Width = 150;
            // 
            // cFDN
            // 
            this.cFDN.DataPropertyName = "cFDN";
            this.cFDN.HeaderText = "Fecha Nacimiento";
            this.cFDN.Name = "cFDN";
            // 
            // cDescripcion
            // 
            this.cDescripcion.DataPropertyName = "cDescripcion";
            this.cDescripcion.HeaderText = "Descripcion";
            this.cDescripcion.Name = "cDescripcion";
            this.cDescripcion.Width = 150;
            // 
            // cCorre
            // 
            this.cCorre.DataPropertyName = "cCorre";
            this.cCorre.HeaderText = "Correo";
            this.cCorre.Name = "cCorre";
            // 
            // cNivelStudio
            // 
            this.cNivelStudio.DataPropertyName = "cNivelStudio";
            this.cNivelStudio.HeaderText = "Nivel Studio";
            this.cNivelStudio.Name = "cNivelStudio";
            // 
            // cRaking
            // 
            this.cRaking.DataPropertyName = "cRaking";
            this.cRaking.HeaderText = "Raking";
            this.cRaking.Name = "cRaking";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 404);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 33);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(187, 404);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 33);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(741, 404);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 33);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Checked = true;
            this.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatus.Location = new System.Drawing.Point(741, 357);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(75, 24);
            this.chkStatus.TabIndex = 7;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.chkStatus_CheckedChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 404);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 33);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmMainCandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 449);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainCandidata";
            this.Text = "Candidata";
            this.Load += new System.EventHandler(this.frmMainCandidata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkCandidata;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCorre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNivelStudio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRaking;
        private System.Windows.Forms.Button btnModificar;
    }
}