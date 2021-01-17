namespace WindowsFormsApplication2
{
    partial class Agendar_Consulta
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
            this.data_Medico_Consulta = new System.Windows.Forms.DataGridView();
            this.dataPaciente_Consulta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateAgendar = new System.Windows.Forms.DateTimePicker();
            this.comboHoras = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btInserirConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_Medico_Consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaciente_Consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // data_Medico_Consulta
            // 
            this.data_Medico_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Medico_Consulta.Location = new System.Drawing.Point(30, 37);
            this.data_Medico_Consulta.MultiSelect = false;
            this.data_Medico_Consulta.Name = "data_Medico_Consulta";
            this.data_Medico_Consulta.ReadOnly = true;
            this.data_Medico_Consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Medico_Consulta.Size = new System.Drawing.Size(302, 239);
            this.data_Medico_Consulta.TabIndex = 0;
            // 
            // dataPaciente_Consulta
            // 
            this.dataPaciente_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPaciente_Consulta.Location = new System.Drawing.Point(455, 37);
            this.dataPaciente_Consulta.MultiSelect = false;
            this.dataPaciente_Consulta.Name = "dataPaciente_Consulta";
            this.dataPaciente_Consulta.ReadOnly = true;
            this.dataPaciente_Consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPaciente_Consulta.Size = new System.Drawing.Size(308, 239);
            this.dataPaciente_Consulta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Indique o médico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Indique o paciente:";
            // 
            // dateAgendar
            // 
            this.dateAgendar.CustomFormat = "yyyy-MM-dd";
            this.dateAgendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAgendar.Location = new System.Drawing.Point(212, 336);
            this.dateAgendar.Name = "dateAgendar";
            this.dateAgendar.Size = new System.Drawing.Size(200, 20);
            this.dateAgendar.TabIndex = 4;
            // 
            // comboHoras
            // 
            this.comboHoras.FormattingEnabled = true;
            this.comboHoras.Items.AddRange(new object[] {
            " 8:00:00",
            " 8:30:00",
            " 9:00:00",
            " 9:30:00",
            " 10:00:00",
            " 10:30:00",
            " 11:00:00",
            " 11:30:00",
            " 12:00:00",
            " 12:30:00",
            " 13:00:00",
            " 13:30:00",
            " 14:00:00",
            " 14:30:00",
            " 15:00:00",
            " 15:30:00",
            " 16:00:00",
            " 16:30:00"});
            this.comboHoras.Location = new System.Drawing.Point(446, 335);
            this.comboHoras.Name = "comboHoras";
            this.comboHoras.Size = new System.Drawing.Size(121, 21);
            this.comboHoras.TabIndex = 5;
            this.comboHoras.Text = " 08:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Indique a data e a hora da consulta";
            // 
            // btInserirConsulta
            // 
            this.btInserirConsulta.Location = new System.Drawing.Point(369, 395);
            this.btInserirConsulta.Name = "btInserirConsulta";
            this.btInserirConsulta.Size = new System.Drawing.Size(75, 23);
            this.btInserirConsulta.TabIndex = 7;
            this.btInserirConsulta.Text = "Inserir";
            this.btInserirConsulta.UseVisualStyleBackColor = true;
            this.btInserirConsulta.Click += new System.EventHandler(this.btInserirConsulta_Click);
            // 
            // Agendar_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.btInserirConsulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboHoras);
            this.Controls.Add(this.dateAgendar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataPaciente_Consulta);
            this.Controls.Add(this.data_Medico_Consulta);
            this.Name = "Agendar_Consulta";
            this.Text = "Agendar_Consulta";
            this.Load += new System.EventHandler(this.Agendar_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Medico_Consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaciente_Consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_Medico_Consulta;
        private System.Windows.Forms.DataGridView dataPaciente_Consulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateAgendar;
        private System.Windows.Forms.ComboBox comboHoras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btInserirConsulta;
    }
}