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
    public partial class Agendar_Consulta : Form
    {
        private MySqlConnection mConn;

        public Agendar_Consulta()
        {
            InitializeComponent();
            mConn = new MySqlConnection("Persist Security Info=False; server=localhost; database=clínica_bwell; uid=root;password=1234");
        }

        private void btInserirConsulta_Click(object sender, EventArgs e)
        {
            string escolher_medico = data_Medico_Consulta.SelectedRows[0].Cells[0].Value.ToString();
            string escolher_paciente = dataPaciente_Consulta.SelectedRows[0].Cells[0].Value.ToString();

            mConn.Open();

            if (mConn.State == ConnectionState.Open)
            {
                //conta quantas linhas o ID Médico e o ID Paciente escolhidos correspondem na tabela consultas
                string SQLquery = @"SELECT count(*) from consulta 
                where idMedico= '"+ escolher_medico+"' and Data = '"+ dateAgendar.Text + comboHoras.Text +"'or idPaciente = '"+escolher_paciente+"' and Data = '"+ dateAgendar.Text + comboHoras.Text +"' or idMedico='"+escolher_medico+"' and idPaciente = '"+escolher_paciente+"' and Data = '"+ dateAgendar.Text + comboHoras.Text +"'";
                MySqlCommand mCommand = new MySqlCommand(SQLquery, mConn);
                //Obtenção de um valor escalar da query anterior
                int count_consultas = Convert.ToInt32(mCommand.ExecuteScalar());

                if (count_consultas == 1)
                {
                    MessageBox.Show("Não é possível agendar essa consulta!");
                    mConn.Close();
                    //Abre uma nova Form - Menu Administrativo
                    Menu_Administrativo f_admin = new Menu_Administrativo();
                    f_admin.ShowDialog();
                }
                else
                {
                    if (count_consultas == 0)
                    {
                       
                        if (mConn.State == ConnectionState.Open)
                        {

                            //inserir valores na tabela consulta
                            string SQLquery2 = "INSERT INTO consulta VALUES('" + escolher_medico + "','" + escolher_paciente +
                                                "','" + dateAgendar.Text + comboHoras.Text + "','" + "diagnostico em falta" + "')";

                            MySqlCommand mCommand1 = new MySqlCommand(SQLquery2, mConn);
                            mCommand1.ExecuteNonQuery();

                            //informa o administrativo de que os dados foram inseridos corretamente
                            MessageBox.Show("Dados inseridos com sucesso!");
                            mConn.Close();
                            Close();
                            
                        }

                        else
                        {
                            MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

      
        private void Agendar_Consulta_Load(object sender, EventArgs e)
        {
            Lista_Medico();
            Lista_Paciente(); 
        }

        private void Lista_Paciente()
        {
            mConn.Open();

            if (mConn.State == ConnectionState.Open)
            {
                //lista o ID e o nome dos pacientes
                string SQLquery = @"Select idPaciente as 'ID Paciente', Nome as 'Paciente' from paciente";
                DataSet mDataSet = new DataSet();
                MySqlDataAdapter mDataAdapter1 = new MySqlDataAdapter(SQLquery, mConn);
                mDataAdapter1.Fill(mDataSet, "Tabela Paciente");
                dataPaciente_Consulta.DataSource = mDataSet;
                dataPaciente_Consulta.DataMember = "Tabela Paciente";

                mConn.Close();
            }

            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Lista_Medico()
        {
            mConn.Open();

            if (mConn.State == ConnectionState.Open)
            {
                //lista o ID e o nome dos médicos
                string SQLquery = @"Select idMedico as 'ID Médico(a)', Nome as 'Médico(a)' from medico";
                DataSet mDataSet = new DataSet();
                MySqlDataAdapter mDataAdapter1 = new MySqlDataAdapter(SQLquery, mConn);
                mDataAdapter1.Fill(mDataSet, "Tabela Medico");
                data_Medico_Consulta.DataSource = mDataSet;
                data_Medico_Consulta.DataMember = "Tabela Medico";

                mConn.Close();
            }

            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
