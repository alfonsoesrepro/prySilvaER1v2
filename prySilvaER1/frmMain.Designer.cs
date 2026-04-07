namespace prySilvaER1
{
    partial class frmMain
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
            this.groupBoxEspecialidades = new System.Windows.Forms.GroupBox();
            this.btnAgregarEspecialidad = new System.Windows.Forms.Button();
            this.txtEspecialidadNombre = new System.Windows.Forms.TextBox();
            this.txtEspecialidadId = new System.Windows.Forms.TextBox();
            this.lblEspecialidadNombre = new System.Windows.Forms.Label();
            this.lblEspecialidadId = new System.Windows.Forms.Label();
            this.groupBoxMedicos = new System.Windows.Forms.GroupBox();
            this.btnAgregarMedico = new System.Windows.Forms.Button();
            this.cmbMedEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtMedicoNombre = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMedEspecialidad = new System.Windows.Forms.Label();
            this.lblMedicoNombre = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.groupBoxConsulta = new System.Windows.Forms.GroupBox();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.cmbEspecialidadesConsulta = new System.Windows.Forms.ComboBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.clmMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxEspecialidades.SuspendLayout();
            this.groupBoxMedicos.SuspendLayout();
            this.groupBoxConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEspecialidades
            // 
            this.groupBoxEspecialidades.Controls.Add(this.btnAgregarEspecialidad);
            this.groupBoxEspecialidades.Controls.Add(this.txtEspecialidadNombre);
            this.groupBoxEspecialidades.Controls.Add(this.txtEspecialidadId);
            this.groupBoxEspecialidades.Controls.Add(this.lblEspecialidadNombre);
            this.groupBoxEspecialidades.Controls.Add(this.lblEspecialidadId);
            this.groupBoxEspecialidades.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEspecialidades.Name = "groupBoxEspecialidades";
            this.groupBoxEspecialidades.Size = new System.Drawing.Size(280, 130);
            this.groupBoxEspecialidades.TabIndex = 0;
            this.groupBoxEspecialidades.TabStop = false;
            this.groupBoxEspecialidades.Text = "Especialidades";
            // 
            // btnAgregarEspecialidad
            // 
            this.btnAgregarEspecialidad.Location = new System.Drawing.Point(169, 88);
            this.btnAgregarEspecialidad.Name = "btnAgregarEspecialidad";
            this.btnAgregarEspecialidad.Size = new System.Drawing.Size(90, 28);
            this.btnAgregarEspecialidad.TabIndex = 4;
            this.btnAgregarEspecialidad.Text = "Agregar";
            this.btnAgregarEspecialidad.UseVisualStyleBackColor = true;
            this.btnAgregarEspecialidad.Click += new System.EventHandler(this.btnAgregarEspecialidad_Click);
            // 
            // txtEspecialidadNombre
            // 
            this.txtEspecialidadNombre.Location = new System.Drawing.Point(95, 52);
            this.txtEspecialidadNombre.Name = "txtEspecialidadNombre";
            this.txtEspecialidadNombre.Size = new System.Drawing.Size(164, 20);
            this.txtEspecialidadNombre.TabIndex = 3;
            // 
            // txtEspecialidadId
            // 
            this.txtEspecialidadId.Location = new System.Drawing.Point(95, 24);
            this.txtEspecialidadId.Name = "txtEspecialidadId";
            this.txtEspecialidadId.Size = new System.Drawing.Size(164, 20);
            this.txtEspecialidadId.TabIndex = 2;
            // 
            // lblEspecialidadNombre
            // 
            this.lblEspecialidadNombre.AutoSize = true;
            this.lblEspecialidadNombre.Location = new System.Drawing.Point(16, 55);
            this.lblEspecialidadNombre.Name = "lblEspecialidadNombre";
            this.lblEspecialidadNombre.Size = new System.Drawing.Size(47, 13);
            this.lblEspecialidadNombre.TabIndex = 1;
            this.lblEspecialidadNombre.Text = "Nombre:";
            // 
            // lblEspecialidadId
            // 
            this.lblEspecialidadId.AutoSize = true;
            this.lblEspecialidadId.Location = new System.Drawing.Point(16, 27);
            this.lblEspecialidadId.Name = "lblEspecialidadId";
            this.lblEspecialidadId.Size = new System.Drawing.Size(47, 13);
            this.lblEspecialidadId.TabIndex = 0;
            this.lblEspecialidadId.Text = "Número:";
            // 
            // groupBoxMedicos
            // 
            this.groupBoxMedicos.Controls.Add(this.btnAgregarMedico);
            this.groupBoxMedicos.Controls.Add(this.cmbMedEspecialidad);
            this.groupBoxMedicos.Controls.Add(this.txtMedicoNombre);
            this.groupBoxMedicos.Controls.Add(this.txtMatricula);
            this.groupBoxMedicos.Controls.Add(this.lblMedEspecialidad);
            this.groupBoxMedicos.Controls.Add(this.lblMedicoNombre);
            this.groupBoxMedicos.Controls.Add(this.lblMatricula);
            this.groupBoxMedicos.Location = new System.Drawing.Point(308, 12);
            this.groupBoxMedicos.Name = "groupBoxMedicos";
            this.groupBoxMedicos.Size = new System.Drawing.Size(280, 170);
            this.groupBoxMedicos.TabIndex = 1;
            this.groupBoxMedicos.TabStop = false;
            this.groupBoxMedicos.Text = "Médicos";
            // 
            // btnAgregarMedico
            // 
            this.btnAgregarMedico.Location = new System.Drawing.Point(169, 126);
            this.btnAgregarMedico.Name = "btnAgregarMedico";
            this.btnAgregarMedico.Size = new System.Drawing.Size(90, 28);
            this.btnAgregarMedico.TabIndex = 6;
            this.btnAgregarMedico.Text = "Agregar";
            this.btnAgregarMedico.UseVisualStyleBackColor = true;
            this.btnAgregarMedico.Click += new System.EventHandler(this.btnAgregarMedico_Click);
            // 
            // cmbMedEspecialidad
            // 
            this.cmbMedEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedEspecialidad.FormattingEnabled = true;
            this.cmbMedEspecialidad.Location = new System.Drawing.Point(95, 86);
            this.cmbMedEspecialidad.Name = "cmbMedEspecialidad";
            this.cmbMedEspecialidad.Size = new System.Drawing.Size(164, 21);
            this.cmbMedEspecialidad.TabIndex = 5;
            // 
            // txtMedicoNombre
            // 
            this.txtMedicoNombre.Location = new System.Drawing.Point(95, 54);
            this.txtMedicoNombre.Name = "txtMedicoNombre";
            this.txtMedicoNombre.Size = new System.Drawing.Size(164, 20);
            this.txtMedicoNombre.TabIndex = 4;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(95, 24);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(164, 20);
            this.txtMatricula.TabIndex = 3;
            // 
            // lblMedEspecialidad
            // 
            this.lblMedEspecialidad.AutoSize = true;
            this.lblMedEspecialidad.Location = new System.Drawing.Point(16, 89);
            this.lblMedEspecialidad.Name = "lblMedEspecialidad";
            this.lblMedEspecialidad.Size = new System.Drawing.Size(70, 13);
            this.lblMedEspecialidad.TabIndex = 2;
            this.lblMedEspecialidad.Text = "Especialidad:";
            // 
            // lblMedicoNombre
            // 
            this.lblMedicoNombre.AutoSize = true;
            this.lblMedicoNombre.Location = new System.Drawing.Point(16, 57);
            this.lblMedicoNombre.Name = "lblMedicoNombre";
            this.lblMedicoNombre.Size = new System.Drawing.Size(47, 13);
            this.lblMedicoNombre.TabIndex = 1;
            this.lblMedicoNombre.Text = "Nombre:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(16, 27);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(55, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // groupBoxConsulta
            // 
            this.groupBoxConsulta.Controls.Add(this.dgvMedicos);
            this.groupBoxConsulta.Controls.Add(this.cmbEspecialidadesConsulta);
            this.groupBoxConsulta.Controls.Add(this.lblConsulta);
            this.groupBoxConsulta.Location = new System.Drawing.Point(12, 188);
            this.groupBoxConsulta.Name = "groupBoxConsulta";
            this.groupBoxConsulta.Size = new System.Drawing.Size(576, 313);
            this.groupBoxConsulta.TabIndex = 2;
            this.groupBoxConsulta.TabStop = false;
            this.groupBoxConsulta.Text = "Consulta por Especialidad";
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.AllowUserToDeleteRows = false;
            this.dgvMedicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMatricula,
            this.clmNombre});
            this.dgvMedicos.Location = new System.Drawing.Point(19, 62);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.RowHeadersVisible = false;
            this.dgvMedicos.Size = new System.Drawing.Size(540, 235);
            this.dgvMedicos.TabIndex = 2;
            // 
            // cmbEspecialidadesConsulta
            // 
            this.cmbEspecialidadesConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidadesConsulta.FormattingEnabled = true;
            this.cmbEspecialidadesConsulta.Location = new System.Drawing.Point(95, 25);
            this.cmbEspecialidadesConsulta.Name = "cmbEspecialidadesConsulta";
            this.cmbEspecialidadesConsulta.Size = new System.Drawing.Size(176, 21);
            this.cmbEspecialidadesConsulta.TabIndex = 1;
            this.cmbEspecialidadesConsulta.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidadesConsulta_SelectedIndexChanged);
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(16, 28);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(70, 13);
            this.lblConsulta.TabIndex = 0;
            this.lblConsulta.Text = "Especialidad:";
            // 
            // clmMatricula
            // 
            this.clmMatricula.HeaderText = "Matrícula";
            this.clmMatricula.Name = "clmMatricula";
            this.clmMatricula.ReadOnly = true;
            this.clmMatricula.Width = 270;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 270;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 511);
            this.Controls.Add(this.groupBoxConsulta);
            this.Controls.Add(this.groupBoxMedicos);
            this.Controls.Add(this.groupBoxEspecialidades);
            this.Name = "frmMain";
            this.Text = "Gestión Clínica - Médicos y Especialidades";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBoxEspecialidades.ResumeLayout(false);
            this.groupBoxEspecialidades.PerformLayout();
            this.groupBoxMedicos.ResumeLayout(false);
            this.groupBoxMedicos.PerformLayout();
            this.groupBoxConsulta.ResumeLayout(false);
            this.groupBoxConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEspecialidades;
        private System.Windows.Forms.Button btnAgregarEspecialidad;
        private System.Windows.Forms.TextBox txtEspecialidadNombre;
        private System.Windows.Forms.TextBox txtEspecialidadId;
        private System.Windows.Forms.Label lblEspecialidadNombre;
        private System.Windows.Forms.Label lblEspecialidadId;
        private System.Windows.Forms.GroupBox groupBoxMedicos;
        private System.Windows.Forms.Button btnAgregarMedico;
        private System.Windows.Forms.ComboBox cmbMedEspecialidad;
        private System.Windows.Forms.TextBox txtMedicoNombre;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMedEspecialidad;
        private System.Windows.Forms.Label lblMedicoNombre;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.GroupBox groupBoxConsulta;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.ComboBox cmbEspecialidadesConsulta;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
    }
}

