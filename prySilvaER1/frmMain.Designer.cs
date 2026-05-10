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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBoxEspecialidades = new System.Windows.Forms.GroupBox();
            this.btnAgregarE = new System.Windows.Forms.Button();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblEspecialidadNombre = new System.Windows.Forms.Label();
            this.lblEspecialidadId = new System.Windows.Forms.Label();
            this.groupBoxMedicos = new System.Windows.Forms.GroupBox();
            this.btnAgregarM = new System.Windows.Forms.Button();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMedEspecialidad = new System.Windows.Forms.Label();
            this.lblMedicoNombre = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.groupBoxConsulta = new System.Windows.Forms.GroupBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.clmMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbConsulta = new System.Windows.Forms.ComboBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBoxEspecialidades.SuspendLayout();
            this.groupBoxMedicos.SuspendLayout();
            this.groupBoxConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEspecialidades
            // 
            this.groupBoxEspecialidades.Controls.Add(this.btnAgregarE);
            this.groupBoxEspecialidades.Controls.Add(this.txtNombreE);
            this.groupBoxEspecialidades.Controls.Add(this.txtNumero);
            this.groupBoxEspecialidades.Controls.Add(this.lblEspecialidadNombre);
            this.groupBoxEspecialidades.Controls.Add(this.lblEspecialidadId);
            this.groupBoxEspecialidades.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEspecialidades.Name = "groupBoxEspecialidades";
            this.groupBoxEspecialidades.Size = new System.Drawing.Size(280, 130);
            this.groupBoxEspecialidades.TabIndex = 0;
            this.groupBoxEspecialidades.TabStop = false;
            this.groupBoxEspecialidades.Text = "Especialidades";
            // 
            // btnAgregarE
            // 
            this.btnAgregarE.Location = new System.Drawing.Point(169, 88);
            this.btnAgregarE.Name = "btnAgregarE";
            this.btnAgregarE.Size = new System.Drawing.Size(90, 28);
            this.btnAgregarE.TabIndex = 4;
            this.btnAgregarE.Text = "Agregar";
            this.btnAgregarE.UseVisualStyleBackColor = true;
            this.btnAgregarE.Click += new System.EventHandler(this.btnAgregarE_Click);
            // 
            // txtNombreE
            // 
            this.txtNombreE.Location = new System.Drawing.Point(95, 52);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(164, 20);
            this.txtNombreE.TabIndex = 3;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(95, 24);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(164, 20);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
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
            this.groupBoxMedicos.Controls.Add(this.btnAgregarM);
            this.groupBoxMedicos.Controls.Add(this.cmbEspecialidad);
            this.groupBoxMedicos.Controls.Add(this.txtNombreM);
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
            // btnAgregarM
            // 
            this.btnAgregarM.Location = new System.Drawing.Point(169, 126);
            this.btnAgregarM.Name = "btnAgregarM";
            this.btnAgregarM.Size = new System.Drawing.Size(90, 28);
            this.btnAgregarM.TabIndex = 6;
            this.btnAgregarM.Text = "Agregar";
            this.btnAgregarM.UseVisualStyleBackColor = true;
            this.btnAgregarM.Click += new System.EventHandler(this.btnAgregarM_Click);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(95, 86);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(164, 21);
            this.cmbEspecialidad.TabIndex = 5;
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(95, 54);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(164, 20);
            this.txtNombreM.TabIndex = 4;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(95, 24);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(164, 20);
            this.txtMatricula.TabIndex = 3;
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
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
            this.groupBoxConsulta.Controls.Add(this.btnConsultar);
            this.groupBoxConsulta.Controls.Add(this.dgvConsulta);
            this.groupBoxConsulta.Controls.Add(this.cmbConsulta);
            this.groupBoxConsulta.Controls.Add(this.lblConsulta);
            this.groupBoxConsulta.Location = new System.Drawing.Point(12, 188);
            this.groupBoxConsulta.Name = "groupBoxConsulta";
            this.groupBoxConsulta.Size = new System.Drawing.Size(576, 313);
            this.groupBoxConsulta.TabIndex = 2;
            this.groupBoxConsulta.TabStop = false;
            this.groupBoxConsulta.Text = "Consulta por Especialidad";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMatricula,
            this.clmNombre});
            this.dgvConsulta.Location = new System.Drawing.Point(19, 62);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.Size = new System.Drawing.Size(540, 235);
            this.dgvConsulta.TabIndex = 2;
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
            // cmbConsulta
            // 
            this.cmbConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsulta.FormattingEnabled = true;
            this.cmbConsulta.Location = new System.Drawing.Point(95, 25);
            this.cmbConsulta.Name = "cmbConsulta";
            this.cmbConsulta.Size = new System.Drawing.Size(176, 21);
            this.cmbConsulta.TabIndex = 1;
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
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(315, 20);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 28);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 511);
            this.Controls.Add(this.groupBoxConsulta);
            this.Controls.Add(this.groupBoxMedicos);
            this.Controls.Add(this.groupBoxEspecialidades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Clínica - Médicos y Especialidades";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBoxEspecialidades.ResumeLayout(false);
            this.groupBoxEspecialidades.PerformLayout();
            this.groupBoxMedicos.ResumeLayout(false);
            this.groupBoxMedicos.PerformLayout();
            this.groupBoxConsulta.ResumeLayout(false);
            this.groupBoxConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEspecialidades;
        private System.Windows.Forms.Button btnAgregarE;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblEspecialidadNombre;
        private System.Windows.Forms.Label lblEspecialidadId;
        private System.Windows.Forms.GroupBox groupBoxMedicos;
        private System.Windows.Forms.Button btnAgregarM;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMedEspecialidad;
        private System.Windows.Forms.Label lblMedicoNombre;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.GroupBox groupBoxConsulta;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.ComboBox cmbConsulta;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.Button btnConsultar;
    }
}

