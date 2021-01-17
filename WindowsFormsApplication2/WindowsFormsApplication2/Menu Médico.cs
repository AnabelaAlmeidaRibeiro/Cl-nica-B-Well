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
    public partial class Menu_Medico : Form
    {

        private MySqlConnection mConn;

        public Menu_Medico()
        {
            InitializeComponent();
            mConn = new MySqlConnection("Persist Security Info=False; server=localhost; database=clínica_bwell; uid=root;password=1234");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Fecha a windows form
            Close();
        }

        private void Menu_Médico_Load(object sender, EventArgs e)
        {
            //Atualiza todas as dataGriedViews
            Atualiza_MenuMedico(); 
        }

        
        private void Atualiza_Consultas()
        {
            mConn.Open();

            if (mConn.State == ConnectionState.Open)
            {
                string SQLquery = @"SELECT paciente.idPaciente as 'ID Paciente',paciente.Nome as 'Paciente', consulta.Data as 'Data e Hora', consulta.diagnostico as 'Diagnóstico'  
                FROM paciente, consulta where paciente.idPaciente = consulta.idPaciente and consulta.Data like '" + dateTimePicker1.Text + "%'";
                                                                                                                //não necessita de uma variável nova
                DataSet mDataSet = new DataSet();
                MySqlDataAdapter mDataAdapter1 = new MySqlDataAdapter(SQLquery, mConn);
                mDataAdapter1.Fill(mDataSet, "Tabela Data");
                dataConsulta_Medico.DataSource = mDataSet;
                dataConsulta_Medico.DataMember = "Tabela Data";

                mConn.Close();
            }

            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Atualiza_MenuMedico()
        {
            //Conexão à base de dados - mostra todos os pacientes
            Atualiza_Pacientes();
            // abre a conexão à base de dados - selecciona os dados dos pacientes que têm/tiveram consulta nessa data
            Atualiza_Consultas();

        }

        //Apresenta o nome do Paciente
        private void Atualiza_Pacientes()
        {
            mConn.Open();

            if (mConn.State == ConnectionState.Open)
            {
                string SQLquery = @"Select Nome from paciente";
                DataSet mDataSet = new DataSet();
                MySqlDataAdapter mDataAdapter = new MySqlDataAdapter(SQLquery, mConn);
                mDataAdapter.Fill(mDataSet, "Tabela Paciente");
                dataPaciente_Medico.DataSource = mDataSet;
                dataPaciente_Medico.DataMember = "Tabela Paciente";

                mConn.Close();
            }

            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            Atualiza_MenuMedico(); 
            
        }

        // o evento click - o médico seleciona o diagnóstico que quer editar
        private void dataConsulta_Medico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //transcreve para a TextBox o texto selecionado
            txtDiagnostico.Text = dataConsulta_Medico.SelectedRows[0].Cells[3].Value.ToString();
            lbID.Text = dataConsulta_Medico.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btEditaDiagnostico_Click(object sender, EventArgs e)
        {
            mConn.Open();
            if (mConn.State == ConnectionState.Open)
            {

                //Update diagnóstico na tabela paciente
                string SQLquery = "Update consulta Set diagnostico = '" + txtDiagnostico.Text + "' where idPaciente = '" + lbID.Text + "'";
                MySqlCommand mCommand = new MySqlCommand(SQLquery, mConn);
                mCommand.ExecuteNonQuery();

                //informa que os dados foram inseridos corretamente
                MessageBox.Show("Dados modificados com sucesso!");

                mConn.Close();
            }

            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Atualiza_MenuMedico();

        }

        //Mostra os dados relativos a consultas do paciente escolhido
        private void btMPaciente_Click(object sender, EventArgs e)
        {
            mConn.Open();
            if (mConn.State == ConnectionState.Open)
            {
                string SQLquery = @"Select medico.Nome as 'Médico(a)', consulta.Data as 'Data e Hora', consulta.diagnostico as 'Diagnóstico'
                from medico, consulta, paciente 
                where medico.idMedico = consulta.idMedico and paciente.idPaciente = consulta.idPaciente and paciente.Nome = '" + txtPacienteConsultar.Text + "'";
                DataSet mDataSet = new DataSet();
                MySqlDataAdapter mDataAdapter = new MySqlDataAdapter(SQLquery, mConn);
                mDataAdapter.Fill(mDataSet, "Tabela Paciente_Consulta");
                dataConsultarMedico.DataSource = mDataSet;
                dataConsultarMedico.DataMember = "Tabela Paciente_Consulta";

                mConn.Close();
            }

            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataPaciente_Medico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Transcreve para a TextBox o Nome do Paciente
            txtPacienteConsultar.Text = dataPaciente_Medico.SelectedRows[0].Cells[0].Value.ToString();
        }


     
    }
}
