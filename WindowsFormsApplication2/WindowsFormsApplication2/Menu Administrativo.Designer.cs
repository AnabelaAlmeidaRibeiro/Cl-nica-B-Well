namespace WindowsFormsApplication2
{
    partial class Menu_Administrativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Administrativo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboEspecialidade = new System.Windows.Forms.ComboBox();
            this.txtID_medico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelef = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btDespedirMedico = new System.Windows.Forms.Button();
            this.btNovoMedico = new System.Windows.Forms.Button();
            this.dataMedico_Admin = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtIDPaciente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMoradaPaciente = new System.Windows.Forms.TextBox();
            this.txtInserirNomePaciente = new System.Windows.Forms.TextBox();
            this.txtInserirMoradaCliente = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.btModificarPaciente = new System.Windows.Forms.Button();
            this.btNovoPaciente = new System.Windows.Forms.Button();
            this.dataPaciente_Admin = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Data_Consulta = new System.Windows.Forms.TextBox();
            this.txtID_Paciente_Consulta = new System.Windows.Forms.TextBox();
            this.btCancelarConsulta = new System.Windows.Forms.Button();
            this.btAgendarConsulta = new System.Windows.Forms.Button();
            this.dataConsulta_Admin = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDMedicoDir = new System.Windows.Forms.TextBox();
            this.btAlterarDiretor = new System.Windows.Forms.Button();
            this.dataEspecialidade_Admin = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btrefresh = new System.Windows.Forms.Button();
            this.comboEstatic = new System.Windows.Forms.ComboBox();
            this.btEstaticOK = new System.Windows.Forms.Button();
            this.dataEstatistica = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataPaciente_Estatic = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.dataTotalConsultas = new System.Windows.Forms.DataGridView();
            this.btVer = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboTempoInicial = new System.Windows.Forms.ComboBox();
            this.comboTempoFinal = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dataConsultaTempo = new System.Windows.Forms.DataGridView();
            this.btIntervalo = new System.Windows.Forms.Button();
            this.checkAgrupar = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMedico_Admin)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaciente_Admin)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsulta_Admin)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEspecialidade_Admin)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEstatistica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaciente_Estatic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTotalConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultaTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboEspecialidade);
            this.tabPage1.Controls.Add(this.txtID_medico);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtTelef);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.txtPass);
            this.tabPage1.Controls.Add(this.btDespedirMedico);
            this.tabPage1.Controls.Add(this.btNovoMedico);
            this.tabPage1.Controls.Add(this.dataMedico_Admin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Médicos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboEspecialidade
            // 
            this.comboEspecialidade.FormattingEnabled = true;
            this.comboEspecialidade.Items.AddRange(new object[] {
            "Psicologia",
            "Oftalmologia",
            "Dermatologia"});
            this.comboEspecialidade.Location = new System.Drawing.Point(663, 84);
            this.comboEspecialidade.Name = "comboEspecialidade";
            this.comboEspecialidade.Size = new System.Drawing.Size(113, 21);
            this.comboEspecialidade.TabIndex = 14;
            // 
            // txtID_medico
            // 
            this.txtID_medico.Location = new System.Drawing.Point(415, 66);
            this.txtID_medico.Name = "txtID_medico";
            this.txtID_medico.Size = new System.Drawing.Size(200, 20);
            this.txtID_medico.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Especialidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // txtTelef
            // 
            this.txtTelef.Location = new System.Drawing.Point(412, 210);
            this.txtTelef.Name = "txtTelef";
            this.txtTelef.Size = new System.Drawing.Size(203, 20);
            this.txtTelef.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(412, 164);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(203, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(412, 113);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(203, 20);
            this.txtPass.TabIndex = 4;
            // 
            // btDespedirMedico
            // 
            this.btDespedirMedico.Location = new System.Drawing.Point(663, 198);
            this.btDespedirMedico.Name = "btDespedirMedico";
            this.btDespedirMedico.Size = new System.Drawing.Size(113, 32);
            this.btDespedirMedico.TabIndex = 2;
            this.btDespedirMedico.Text = "Remover";
            this.btDespedirMedico.UseVisualStyleBackColor = true;
            this.btDespedirMedico.Click += new System.EventHandler(this.btDespedirMedico_Click);
            // 
            // btNovoMedico
            // 
            this.btNovoMedico.Location = new System.Drawing.Point(663, 139);
            this.btNovoMedico.Name = "btNovoMedico";
            this.btNovoMedico.Size = new System.Drawing.Size(112, 31);
            this.btNovoMedico.TabIndex = 1;
            this.btNovoMedico.Text = "Inserir";
            this.btNovoMedico.UseVisualStyleBackColor = true;
            this.btNovoMedico.Click += new System.EventHandler(this.btNovoMedico_Click);
            // 
            // dataMedico_Admin
            // 
            this.dataMedico_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMedico_Admin.Location = new System.Drawing.Point(22, 29);
            this.dataMedico_Admin.MultiSelect = false;
            this.dataMedico_Admin.Name = "dataMedico_Admin";
            this.dataMedico_Admin.ReadOnly = true;
            this.dataMedico_Admin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMedico_Admin.Size = new System.Drawing.Size(354, 233);
            this.dataMedico_Admin.TabIndex = 0;
            this.dataMedico_Admin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMedico_Admin_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtIDPaciente);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtMoradaPaciente);
            this.tabPage2.Controls.Add(this.txtInserirNomePaciente);
            this.tabPage2.Controls.Add(this.txtInserirMoradaCliente);
            this.tabPage2.Controls.Add(this.Nome);
            this.tabPage2.Controls.Add(this.btModificarPaciente);
            this.tabPage2.Controls.Add(this.btNovoPaciente);
            this.tabPage2.Controls.Add(this.dataPaciente_Admin);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(826, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pacientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtIDPaciente
            // 
            this.txtIDPaciente.Location = new System.Drawing.Point(504, 70);
            this.txtIDPaciente.Name = "txtIDPaciente";
            this.txtIDPaciente.Size = new System.Drawing.Size(282, 20);
            this.txtIDPaciente.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "ID";
            // 
            // txtMoradaPaciente
            // 
            this.txtMoradaPaciente.Location = new System.Drawing.Point(504, 195);
            this.txtMoradaPaciente.Name = "txtMoradaPaciente";
            this.txtMoradaPaciente.Size = new System.Drawing.Size(282, 20);
            this.txtMoradaPaciente.TabIndex = 6;
            // 
            // txtInserirNomePaciente
            // 
            this.txtInserirNomePaciente.Location = new System.Drawing.Point(504, 133);
            this.txtInserirNomePaciente.Name = "txtInserirNomePaciente";
            this.txtInserirNomePaciente.Size = new System.Drawing.Size(282, 20);
            this.txtInserirNomePaciente.TabIndex = 5;
            // 
            // txtInserirMoradaCliente
            // 
            this.txtInserirMoradaCliente.AutoSize = true;
            this.txtInserirMoradaCliente.Location = new System.Drawing.Point(501, 169);
            this.txtInserirMoradaCliente.Name = "txtInserirMoradaCliente";
            this.txtInserirMoradaCliente.Size = new System.Drawing.Size(43, 13);
            this.txtInserirMoradaCliente.TabIndex = 4;
            this.txtInserirMoradaCliente.Text = "Morada";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(501, 104);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 3;
            this.Nome.Text = "Nome";
            // 
            // btModificarPaciente
            // 
            this.btModificarPaciente.Location = new System.Drawing.Point(681, 243);
            this.btModificarPaciente.Name = "btModificarPaciente";
            this.btModificarPaciente.Size = new System.Drawing.Size(105, 23);
            this.btModificarPaciente.TabIndex = 2;
            this.btModificarPaciente.Text = "Modificar";
            this.btModificarPaciente.UseVisualStyleBackColor = true;
            this.btModificarPaciente.Click += new System.EventHandler(this.btModificarPaciente_Click);
            // 
            // btNovoPaciente
            // 
            this.btNovoPaciente.Location = new System.Drawing.Point(504, 243);
            this.btNovoPaciente.Name = "btNovoPaciente";
            this.btNovoPaciente.Size = new System.Drawing.Size(110, 23);
            this.btNovoPaciente.TabIndex = 1;
            this.btNovoPaciente.Text = "Novo Paciente";
            this.btNovoPaciente.UseCompatibleTextRendering = true;
            this.btNovoPaciente.UseVisualStyleBackColor = true;
            this.btNovoPaciente.Click += new System.EventHandler(this.btNovoPaciente_Click);
            // 
            // dataPaciente_Admin
            // 
            this.dataPaciente_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPaciente_Admin.Location = new System.Drawing.Point(16, 16);
            this.dataPaciente_Admin.MultiSelect = false;
            this.dataPaciente_Admin.Name = "dataPaciente_Admin";
            this.dataPaciente_Admin.ReadOnly = true;
            this.dataPaciente_Admin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPaciente_Admin.Size = new System.Drawing.Size(428, 250);
            this.dataPaciente_Admin.TabIndex = 0;
            this.dataPaciente_Admin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPaciente_Admin_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btrefresh);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txt_Data_Consulta);
            this.tabPage3.Controls.Add(this.txtID_Paciente_Consulta);
            this.tabPage3.Controls.Add(this.btCancelarConsulta);
            this.tabPage3.Controls.Add(this.btAgendarConsulta);
            this.tabPage3.Controls.Add(this.dataConsulta_Admin);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(826, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consultas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(601, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Data e Hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(601, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "ID Paciente";
            // 
            // txt_Data_Consulta
            // 
            this.txt_Data_Consulta.Location = new System.Drawing.Point(601, 118);
            this.txt_Data_Consulta.Name = "txt_Data_Consulta";
            this.txt_Data_Consulta.Size = new System.Drawing.Size(122, 20);
            this.txt_Data_Consulta.TabIndex = 4;
            // 
            // txtID_Paciente_Consulta
            // 
            this.txtID_Paciente_Consulta.Location = new System.Drawing.Point(601, 68);
            this.txtID_Paciente_Consulta.Name = "txtID_Paciente_Consulta";
            this.txtID_Paciente_Consulta.Size = new System.Drawing.Size(122, 20);
            this.txtID_Paciente_Consulta.TabIndex = 3;
            // 
            // btCancelarConsulta
            // 
            this.btCancelarConsulta.Location = new System.Drawing.Point(626, 175);
            this.btCancelarConsulta.Name = "btCancelarConsulta";
            this.btCancelarConsulta.Size = new System.Drawing.Size(75, 23);
            this.btCancelarConsulta.TabIndex = 2;
            this.btCancelarConsulta.Text = "Cancelar";
            this.btCancelarConsulta.UseVisualStyleBackColor = true;
            this.btCancelarConsulta.Click += new System.EventHandler(this.btCancelarConsulta_Click);
            // 
            // btAgendarConsulta
            // 
            this.btAgendarConsulta.Location = new System.Drawing.Point(191, 263);
            this.btAgendarConsulta.Name = "btAgendarConsulta";
            this.btAgendarConsulta.Size = new System.Drawing.Size(140, 45);
            this.btAgendarConsulta.TabIndex = 1;
            this.btAgendarConsulta.Text = "Agendar";
            this.btAgendarConsulta.UseVisualStyleBackColor = true;
            this.btAgendarConsulta.Click += new System.EventHandler(this.btAgendarConsulta_Click);
            // 
            // dataConsulta_Admin
            // 
            this.dataConsulta_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConsulta_Admin.Location = new System.Drawing.Point(6, 25);
            this.dataConsulta_Admin.MultiSelect = false;
            this.dataConsulta_Admin.Name = "dataConsulta_Admin";
            this.dataConsulta_Admin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataConsulta_Admin.Size = new System.Drawing.Size(538, 218);
            this.dataConsulta_Admin.TabIndex = 0;
            this.dataConsulta_Admin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataConsulta_Admin_CellClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txtIDMedicoDir);
            this.tabPage4.Controls.Add(this.btAlterarDiretor);
            this.tabPage4.Controls.Add(this.dataEspecialidade_Admin);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(826, 322);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Especialidade";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(582, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "ID Médico Diretor";
            // 
            // txtIDMedicoDir
            // 
            this.txtIDMedicoDir.Location = new System.Drawing.Point(525, 87);
            this.txtIDMedicoDir.Name = "txtIDMedicoDir";
            this.txtIDMedicoDir.Size = new System.Drawing.Size(211, 20);
            this.txtIDMedicoDir.TabIndex = 2;
            this.txtIDMedicoDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btAlterarDiretor
            // 
            this.btAlterarDiretor.Location = new System.Drawing.Point(477, 139);
            this.btAlterarDiretor.Name = "btAlterarDiretor";
            this.btAlterarDiretor.Size = new System.Drawing.Size(304, 20);
            this.btAlterarDiretor.TabIndex = 1;
            this.btAlterarDiretor.Text = "Alterar Diretor Especialidade";
            this.btAlterarDiretor.UseVisualStyleBackColor = true;
            this.btAlterarDiretor.Click += new System.EventHandler(this.btAlterarDiretor_Click);
            // 
            // dataEspecialidade_Admin
            // 
            this.dataEspecialidade_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEspecialidade_Admin.Location = new System.Drawing.Point(35, 44);
            this.dataEspecialidade_Admin.Name = "dataEspecialidade_Admin";
            this.dataEspecialidade_Admin.ReadOnly = true;
            this.dataEspecialidade_Admin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEspecialidade_Admin.Size = new System.Drawing.Size(375, 204);
            this.dataEspecialidade_Admin.TabIndex = 0;
            this.dataEspecialidade_Admin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEspecialidade_Admin_CellClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.checkAgrupar);
            this.tabPage5.Controls.Add(this.btIntervalo);
            this.tabPage5.Controls.Add(this.dataConsultaTempo);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.comboTempoFinal);
            this.tabPage5.Controls.Add(this.comboTempoInicial);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.btVer);
            this.tabPage5.Controls.Add(this.dataTotalConsultas);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.dataPaciente_Estatic);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.dataEstatistica);
            this.tabPage5.Controls.Add(this.btEstaticOK);
            this.tabPage5.Controls.Add(this.comboEstatic);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(826, 366);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Estatísticas";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // btrefresh
            // 
            this.btrefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btrefresh.BackgroundImage")));
            this.btrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btrefresh.Location = new System.Drawing.Point(550, 6);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(32, 30);
            this.btrefresh.TabIndex = 7;
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // comboEstatic
            // 
            this.comboEstatic.FormattingEnabled = true;
            this.comboEstatic.Items.AddRange(new object[] {
            "Médicos com maior nº de consultas",
            "Data com maior nº de consultas (distribuidas por médico)"});
            this.comboEstatic.Location = new System.Drawing.Point(15, 35);
            this.comboEstatic.Name = "comboEstatic";
            this.comboEstatic.Size = new System.Drawing.Size(405, 21);
            this.comboEstatic.TabIndex = 0;
            // 
            // btEstaticOK
            // 
            this.btEstaticOK.Location = new System.Drawing.Point(442, 35);
            this.btEstaticOK.Name = "btEstaticOK";
            this.btEstaticOK.Size = new System.Drawing.Size(75, 23);
            this.btEstaticOK.TabIndex = 1;
            this.btEstaticOK.Text = "OK";
            this.btEstaticOK.UseVisualStyleBackColor = true;
            this.btEstaticOK.Click += new System.EventHandler(this.btEstaticOK_Click);
            // 
            // dataEstatistica
            // 
            this.dataEstatistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEstatistica.Location = new System.Drawing.Point(568, 6);
            this.dataEstatistica.MultiSelect = false;
            this.dataEstatistica.Name = "dataEstatistica";
            this.dataEstatistica.ReadOnly = true;
            this.dataEstatistica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEstatistica.Size = new System.Drawing.Size(240, 102);
            this.dataEstatistica.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Escolha uma opção: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Escolha o paciente:";
            // 
            // dataPaciente_Estatic
            // 
            this.dataPaciente_Estatic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPaciente_Estatic.Location = new System.Drawing.Point(15, 110);
            this.dataPaciente_Estatic.MultiSelect = false;
            this.dataPaciente_Estatic.Name = "dataPaciente_Estatic";
            this.dataPaciente_Estatic.ReadOnly = true;
            this.dataPaciente_Estatic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPaciente_Estatic.Size = new System.Drawing.Size(221, 88);
            this.dataPaciente_Estatic.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(294, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Consultas desse paciente:";
            // 
            // dataTotalConsultas
            // 
            this.dataTotalConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTotalConsultas.Location = new System.Drawing.Point(297, 110);
            this.dataTotalConsultas.MultiSelect = false;
            this.dataTotalConsultas.Name = "dataTotalConsultas";
            this.dataTotalConsultas.ReadOnly = true;
            this.dataTotalConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTotalConsultas.Size = new System.Drawing.Size(240, 88);
            this.dataTotalConsultas.TabIndex = 7;
            // 
            // btVer
            // 
            this.btVer.Location = new System.Drawing.Point(242, 141);
            this.btVer.Name = "btVer";
            this.btVer.Size = new System.Drawing.Size(48, 23);
            this.btVer.TabIndex = 8;
            this.btVer.Text = "Ver";
            this.btVer.UseVisualStyleBackColor = true;
            this.btVer.Click += new System.EventHandler(this.btVer_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 264);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Seleccione o tempo inicial:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(179, 264);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Seleccione o tempo final:";
            // 
            // comboTempoInicial
            // 
            this.comboTempoInicial.FormattingEnabled = true;
            this.comboTempoInicial.Items.AddRange(new object[] {
            "08:00:00",
            "08:30:00",
            "09:00:00",
            "09:30:00",
            "10:00:00",
            "10:30:00",
            "11:00:00",
            "11:30:00",
            "12:00:00",
            "12:30:00",
            "13:00:00",
            "13:30:00",
            "14:00:00",
            "14:30:00",
            "15:00:00",
            "15:30:00",
            "16:00:00",
            "16:30:00"});
            this.comboTempoInicial.Location = new System.Drawing.Point(18, 280);
            this.comboTempoInicial.Name = "comboTempoInicial";
            this.comboTempoInicial.Size = new System.Drawing.Size(121, 21);
            this.comboTempoInicial.TabIndex = 11;
            this.comboTempoInicial.Text = "08:00:00";
            // 
            // comboTempoFinal
            // 
            this.comboTempoFinal.FormattingEnabled = true;
            this.comboTempoFinal.Items.AddRange(new object[] {
            "08:00:00",
            "08:30:00",
            "09:00:00",
            "09:30:00",
            "10:00:00",
            "10:30:00",
            "11:00:00",
            "11:30:00",
            "12:00:00",
            "12:30:00",
            "13:00:00",
            "13:30:00",
            "14:00:00",
            "14:30:00",
            "15:00:00",
            "15:30:00",
            "16:00:00",
            "16:30:00"});
            this.comboTempoFinal.Location = new System.Drawing.Point(182, 280);
            this.comboTempoFinal.Name = "comboTempoFinal";
            this.comboTempoFinal.Size = new System.Drawing.Size(121, 21);
            this.comboTempoFinal.TabIndex = 12;
            this.comboTempoFinal.Text = "08:00:00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(271, 15);
            this.label15.TabIndex = 14;
            this.label15.Text = "Nº de Consultas por um dado intervalo de tempo";
            // 
            // dataConsultaTempo
            // 
            this.dataConsultaTempo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConsultaTempo.Location = new System.Drawing.Point(540, 239);
            this.dataConsultaTempo.MultiSelect = false;
            this.dataConsultaTempo.Name = "dataConsultaTempo";
            this.dataConsultaTempo.ReadOnly = true;
            this.dataConsultaTempo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataConsultaTempo.Size = new System.Drawing.Size(243, 101);
            this.dataConsultaTempo.TabIndex = 15;
            // 
            // btIntervalo
            // 
            this.btIntervalo.Location = new System.Drawing.Point(74, 317);
            this.btIntervalo.Name = "btIntervalo";
            this.btIntervalo.Size = new System.Drawing.Size(181, 23);
            this.btIntervalo.TabIndex = 16;
            this.btIntervalo.Text = "Consultar";
            this.btIntervalo.UseVisualStyleBackColor = true;
            this.btIntervalo.Click += new System.EventHandler(this.btIntervalo_Click);
            // 
            // checkAgrupar
            // 
            this.checkAgrupar.AutoSize = true;
            this.checkAgrupar.Location = new System.Drawing.Point(332, 284);
            this.checkAgrupar.Name = "checkAgrupar";
            this.checkAgrupar.Size = new System.Drawing.Size(145, 17);
            this.checkAgrupar.TabIndex = 17;
            this.checkAgrupar.Text = "Agrupados por Médico(a)";
            this.checkAgrupar.UseVisualStyleBackColor = true;
            // 
            // Menu_Administrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 443);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_Administrativo";
            this.Text = "Menu_Administrativo";
            this.Load += new System.EventHandler(this.Menu_Administrativo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMedico_Admin)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaciente_Admin)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsulta_Admin)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEspecialidade_Admin)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEstatistica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaciente_Estatic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTotalConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultaTempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btModificarPaciente;
        private System.Windows.Forms.Button btNovoPaciente;
        private System.Windows.Forms.DataGridView dataPaciente_Admin;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataMedico_Admin;
        private System.Windows.Forms.Button btDespedirMedico;
        private System.Windows.Forms.Button btNovoMedico;
        private System.Windows.Forms.DataGridView dataConsulta_Admin;
        private System.Windows.Forms.Button btCancelarConsulta;
        private System.Windows.Forms.Button btAgendarConsulta;
        private System.Windows.Forms.TextBox txtTelef;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoradaPaciente;
        private System.Windows.Forms.TextBox txtInserirNomePaciente;
        private System.Windows.Forms.Label txtInserirMoradaCliente;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtIDMedicoDir;
        private System.Windows.Forms.Button btAlterarDiretor;
        private System.Windows.Forms.DataGridView dataEspecialidade_Admin;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtID_medico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboEspecialidade;
        private System.Windows.Forms.TextBox txtIDPaciente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Data_Consulta;
        private System.Windows.Forms.TextBox txtID_Paciente_Consulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.DataGridView dataEstatistica;
        private System.Windows.Forms.Button btEstaticOK;
        private System.Windows.Forms.ComboBox comboEstatic;
        private System.Windows.Forms.Button btVer;
        private System.Windows.Forms.DataGridView dataTotalConsultas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataPaciente_Estatic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboTempoFinal;
        private System.Windows.Forms.ComboBox comboTempoInicial;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btIntervalo;
        private System.Windows.Forms.DataGridView dataConsultaTempo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkAgrupar;
    }
}