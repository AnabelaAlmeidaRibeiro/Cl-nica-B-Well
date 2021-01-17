namespace WindowsFormsApplication2
{
    partial class Inserir_Paciente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoradaNovoPaciente = new System.Windows.Forms.TextBox();
            this.txtMoradaNovo = new System.Windows.Forms.TextBox();
            this.btInserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Morada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome";
            // 
            // txtMoradaNovoPaciente
            // 
            this.txtMoradaNovoPaciente.Location = new System.Drawing.Point(31, 52);
            this.txtMoradaNovoPaciente.Name = "txtMoradaNovoPaciente";
            this.txtMoradaNovoPaciente.Size = new System.Drawing.Size(302, 20);
            this.txtMoradaNovoPaciente.TabIndex = 8;
            // 
            // txtMoradaNovo
            // 
            this.txtMoradaNovo.Location = new System.Drawing.Point(34, 111);
            this.txtMoradaNovo.Name = "txtMoradaNovo";
            this.txtMoradaNovo.Size = new System.Drawing.Size(299, 20);
            this.txtMoradaNovo.TabIndex = 12;
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(109, 170);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(133, 38);
            this.btInserir.TabIndex = 13;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // Inserir_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 262);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.txtMoradaNovo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoradaNovoPaciente);
            this.Name = "Inserir_Paciente";
            this.Text = "Novo Paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoradaNovoPaciente;
        private System.Windows.Forms.TextBox txtMoradaNovo;
        private System.Windows.Forms.Button btInserir;
    }
}