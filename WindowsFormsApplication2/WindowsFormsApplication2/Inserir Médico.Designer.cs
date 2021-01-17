namespace WindowsFormsApplication2
{
    partial class Inserir_Médico
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
            this.lblNomeNovoMédico = new System.Windows.Forms.Label();
            this.lblTelefoneNovoMédico = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioOftal = new System.Windows.Forms.RadioButton();
            this.radioDerma = new System.Windows.Forms.RadioButton();
            this.radioPsic = new System.Windows.Forms.RadioButton();
            this.txtNome_Medico = new System.Windows.Forms.TextBox();
            this.txt_Telef_Medico = new System.Windows.Forms.TextBox();
            this.btInserirMedico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeNovoMédico
            // 
            this.lblNomeNovoMédico.AutoSize = true;
            this.lblNomeNovoMédico.Location = new System.Drawing.Point(38, 70);
            this.lblNomeNovoMédico.Name = "lblNomeNovoMédico";
            this.lblNomeNovoMédico.Size = new System.Drawing.Size(35, 13);
            this.lblNomeNovoMédico.TabIndex = 0;
            this.lblNomeNovoMédico.Text = "Nome";
            // 
            // lblTelefoneNovoMédico
            // 
            this.lblTelefoneNovoMédico.AutoSize = true;
            this.lblTelefoneNovoMédico.Location = new System.Drawing.Point(38, 109);
            this.lblTelefoneNovoMédico.Name = "lblTelefoneNovoMédico";
            this.lblTelefoneNovoMédico.Size = new System.Drawing.Size(49, 13);
            this.lblTelefoneNovoMédico.TabIndex = 1;
            this.lblTelefoneNovoMédico.Text = "Telefone";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioOftal);
            this.groupBox1.Controls.Add(this.radioDerma);
            this.groupBox1.Controls.Add(this.radioPsic);
            this.groupBox1.Location = new System.Drawing.Point(59, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Especialidade";
            // 
            // radioOftal
            // 
            this.radioOftal.AutoSize = true;
            this.radioOftal.Location = new System.Drawing.Point(176, 28);
            this.radioOftal.Name = "radioOftal";
            this.radioOftal.Size = new System.Drawing.Size(83, 17);
            this.radioOftal.TabIndex = 2;
            this.radioOftal.TabStop = true;
            this.radioOftal.Text = "Oftalmologia";
            this.radioOftal.UseVisualStyleBackColor = true;
            // 
            // radioDerma
            // 
            this.radioDerma.AutoSize = true;
            this.radioDerma.Location = new System.Drawing.Point(20, 69);
            this.radioDerma.Name = "radioDerma";
            this.radioDerma.Size = new System.Drawing.Size(87, 17);
            this.radioDerma.TabIndex = 1;
            this.radioDerma.TabStop = true;
            this.radioDerma.Text = "Dermatologia";
            this.radioDerma.UseVisualStyleBackColor = true;
            // 
            // radioPsic
            // 
            this.radioPsic.AutoSize = true;
            this.radioPsic.Location = new System.Drawing.Point(20, 28);
            this.radioPsic.Name = "radioPsic";
            this.radioPsic.Size = new System.Drawing.Size(73, 17);
            this.radioPsic.TabIndex = 0;
            this.radioPsic.TabStop = true;
            this.radioPsic.Text = "Psicologia";
            this.radioPsic.UseVisualStyleBackColor = true;
            // 
            // txtNome_Medico
            // 
            this.txtNome_Medico.Location = new System.Drawing.Point(59, 86);
            this.txtNome_Medico.Name = "txtNome_Medico";
            this.txtNome_Medico.Size = new System.Drawing.Size(310, 20);
            this.txtNome_Medico.TabIndex = 4;
            // 
            // txt_Telef_Medico
            // 
            this.txt_Telef_Medico.Location = new System.Drawing.Point(59, 134);
            this.txt_Telef_Medico.Name = "txt_Telef_Medico";
            this.txt_Telef_Medico.Size = new System.Drawing.Size(310, 20);
            this.txt_Telef_Medico.TabIndex = 5;
            // 
            // btInserirMedico
            // 
            this.btInserirMedico.Location = new System.Drawing.Point(177, 307);
            this.btInserirMedico.Name = "btInserirMedico";
            this.btInserirMedico.Size = new System.Drawing.Size(75, 23);
            this.btInserirMedico.TabIndex = 6;
            this.btInserirMedico.Text = "Inserir";
            this.btInserirMedico.UseVisualStyleBackColor = true;
            this.btInserirMedico.Click += new System.EventHandler(this.btInserirMedico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(59, 38);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(310, 20);
            this.txtPass.TabIndex = 8;
            // 
            // Inserir_Médico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 366);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btInserirMedico);
            this.Controls.Add(this.txt_Telef_Medico);
            this.Controls.Add(this.txtNome_Medico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTelefoneNovoMédico);
            this.Controls.Add(this.lblNomeNovoMédico);
            this.Name = "Inserir_Médico";
            this.Text = "Inserir Médico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeNovoMédico;
        private System.Windows.Forms.Label lblTelefoneNovoMédico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioOftal;
        private System.Windows.Forms.RadioButton radioDerma;
        private System.Windows.Forms.RadioButton radioPsic;
        private System.Windows.Forms.TextBox txtNome_Medico;
        private System.Windows.Forms.TextBox txt_Telef_Medico;
        private System.Windows.Forms.Button btInserirMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
    }
}