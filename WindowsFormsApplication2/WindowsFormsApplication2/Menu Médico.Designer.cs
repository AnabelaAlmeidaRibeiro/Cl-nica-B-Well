namespace WindowsFormsApplication2
{
    partial class Menu_Medico
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbID = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.dataConsulta_Medico = new System.Windows.Forms.DataGridView();
            this.btEditaDiagnostico = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataPaciente_Medico = new System.Windows.Forms.DataGridView();
            this.txtPacienteConsultar = new System.Windows.Forms.TextBox();
            this.dataConsultarMedico = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btMPaciente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsulta_Medico)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaciente_Medico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultarMedico)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 329);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbID);
            this.tabPage1.Controls.Add(this.txtDiagnostico);
            this.tabPage1.Controls.Add(this.dataConsulta_Medico);
            this.tabPage1.Controls.Add(this.btEditaDiagnostico);
            this.tabPage1.Controls.Add(this.btConsultar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(689, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consultas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(7, 272);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 13);
            this.lbID.TabIndex = 6;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(48, 265);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(253, 20);
            this.txtDiagnostico.TabIndex = 5;
            // 
            // dataConsulta_Medico
            // 
            this.dataConsulta_Medico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConsulta_Medico.Location = new System.Drawing.Point(48, 88);
            this.dataConsulta_Medico.MultiSelect = false;
            this.dataConsulta_Medico.Name = "dataConsulta_Medico";
            this.dataConsulta_Medico.ReadOnly = true;
            this.dataConsulta_Medico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataConsulta_Medico.Size = new System.Drawing.Size(414, 160);
            this.dataConsulta_Medico.TabIndex = 4;
            this.dataConsulta_Medico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataConsulta_Medico_CellClick);
            // 
            // btEditaDiagnostico
            // 
            this.btEditaDiagnostico.Location = new System.Drawing.Point(356, 263);
            this.btEditaDiagnostico.Name = "btEditaDiagnostico";
            this.btEditaDiagnostico.Size = new System.Drawing.Size(122, 23);
            this.btEditaDiagnostico.TabIndex = 3;
            this.btEditaDiagnostico.Text = "Editar diagnóstico";
            this.btEditaDiagnostico.UseVisualStyleBackColor = true;
            this.btEditaDiagnostico.Click += new System.EventHandler(this.btEditaDiagnostico_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(369, 38);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.TabIndex = 2;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha o dia:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(62, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2014, 1, 2, 12, 16, 0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataPaciente_Medico);
            this.tabPage2.Controls.Add(this.txtPacienteConsultar);
            this.tabPage2.Controls.Add(this.dataConsultarMedico);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btMPaciente);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(689, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pacientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataPaciente_Medico
            // 
            this.dataPaciente_Medico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPaciente_Medico.Location = new System.Drawing.Point(38, 51);
            this.dataPaciente_Medico.MultiSelect = false;
            this.dataPaciente_Medico.Name = "dataPaciente_Medico";
            this.dataPaciente_Medico.ReadOnly = true;
            this.dataPaciente_Medico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPaciente_Medico.Size = new System.Drawing.Size(240, 191);
            this.dataPaciente_Medico.TabIndex = 6;
            this.dataPaciente_Medico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPaciente_Medico_CellClick);
            // 
            // txtPacienteConsultar
            // 
            this.txtPacienteConsultar.Location = new System.Drawing.Point(38, 263);
            this.txtPacienteConsultar.Name = "txtPacienteConsultar";
            this.txtPacienteConsultar.Size = new System.Drawing.Size(164, 20);
            this.txtPacienteConsultar.TabIndex = 5;
            // 
            // dataConsultarMedico
            // 
            this.dataConsultarMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConsultarMedico.Location = new System.Drawing.Point(347, 51);
            this.dataConsultarMedico.MultiSelect = false;
            this.dataConsultarMedico.Name = "dataConsultarMedico";
            this.dataConsultarMedico.ReadOnly = true;
            this.dataConsultarMedico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataConsultarMedico.Size = new System.Drawing.Size(322, 191);
            this.dataConsultarMedico.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Consultas";
            // 
            // btMPaciente
            // 
            this.btMPaciente.Location = new System.Drawing.Point(208, 263);
            this.btMPaciente.Name = "btMPaciente";
            this.btMPaciente.Size = new System.Drawing.Size(109, 23);
            this.btMPaciente.TabIndex = 2;
            this.btMPaciente.Text = "Consultar";
            this.btMPaciente.UseVisualStyleBackColor = true;
            this.btMPaciente.Click += new System.EventHandler(this.btMPaciente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escolha o paciente:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(738, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Menu_Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 372);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_Medico";
            this.Text = "Menu Médico";
            this.Load += new System.EventHandler(this.Menu_Médico_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsulta_Medico)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaciente_Medico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultarMedico)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataConsulta_Medico;
        private System.Windows.Forms.Button btEditaDiagnostico;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.DataGridView dataConsultarMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPacienteConsultar;
        private System.Windows.Forms.DataGridView dataPaciente_Medico;
    }
}