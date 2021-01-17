using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Especialidades : Form
    {
        private MySqlConnection mConn;

        public Especialidades()
        {
            InitializeComponent();
            mConn = new MySqlConnection("Persist Security Info=False; server=localhost; database=clínica_bwell; uid=root;password=1234");

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            mConn.Open();

            if (mConn.State == ConnectionState.Open)
            {
                string SQLquery = @"Select medico.nome as 'Médico(a)', especialidade.Designacao as 'Especialidade'
                From especialidade, medico where especialidade.idEspecialidade = medico.idEspecialidade  ";
                DataSet mDataSet = new DataSet();
                MySqlDataAdapter mDataAdapter = new MySqlDataAdapter(SQLquery, mConn);
                mDataAdapter.Fill(mDataSet, "Tabela Especialidade");
                dataAreaPaciente.DataSource = mDataSet;
                dataAreaPaciente.DataMember = "Tabela Especialidade";

                mConn.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
