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
    public partial class Menu_Administrativo : Form
    {
        private MySqlConnection mConn;

        public Menu_Administrativo()
        {
            InitializeComponent();
            mConn = new MySqlConnection("Persist Security Info=False; server=localhost; database=clínica_bwell; uid=root;password=1234");
        }

        //Fecha a janela
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Agendar uma nova consulta
        private void btAgendarConsulta_Click(object sender, EventArgs e)
        {
            Agendar_Consulta fnova_consulta = new Agendar_Consulta();
            fnova_consulta.ShowDialog();
        }

        private void Menu_Administrativo_Load(object sender, EventArgs e)
        {
            //Atualiza as Datas Todas 
            Atualizar_MenuAdministrativo();
        }

        private void Atualizar_Especialidades()
        {
            mConn.Open();

            if (mConn.State == ConnectionState.Open)
            {
                string SQLquery = @"select especialidade.Designacao as 'Especialidade', especialidade.MedicoDiretor as 'ID Médico Diretor', medico.Nome 
                from especialidade, medico where especialidade.MedicoDiretor = medico.idMedico ";
                DataSet mDataSet = new DataSet();
                MySqlDataAdapter mDataAdapter = new MySqlDataAdapter(SQLquery, mConn);

                mDataAdapter.Fill(mDataSet, "Tabela Especialidade");
                dataEspecialidade_Admin.DataSource = mDataSet;
                dataEspecialidade_Admin.DataMember = "Tabela Especialidade";

                mConn.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Atualizar_Consultas()
        {
            mConn.Open();

            if (mConn.State == ConnectionState.Open)
            {
                string SQLquery = @"select paciente.idPaciente as 'ID Paciente', paciente.Nome as 'Paciente', medico.Nome as 'Médico(a)', consulta.Data as 'Data e Hora', consulta.diagnostico as 'Diagnóstico'
                from medico, paciente, consulta where medico.idMedico = consulta.idMedico and paciente.idPaciente = consulta.idPaciente";
                DataSet mDataSet = new DataSet();
                MySqlDataAdapter mDataAdapter = new MySqlDataAdapter(SQLquery, mConn);
                mDataAdapter.Fill(mDataSet, "Tabela Consulta");
                dataConsulta_Admin.DataSource = mDataSet;
                dataConsulta_Admin.DataMember = "Tabela Consulta";

                mConn.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Atualizar_MenuAdministrativo()
        {
            //Conexão à base de dados - mostra os dados dos médicos todos
            Atualizar_Data_Medicos();
            //Conexão à base de dados - mostra os dados dos pacientes todos
            Atualizar_Data_Pacientes();
            //Conexão à base de dados - mostra os dados das consultas 
            Atualizar_Consultas();
            //conexão à BD - mostra as especialidades e os seus diretores
            Atualizar_Especialidades();
            //conexão à BD - mostra o nome dos pacientes
            Atualizar_Pacientes_Estatic(); 

        }

        private void Atualizar_Data_Pacientes()
        {
            mConn.Open();

            if (mConn.State == ConnectionState.Open)
            {
                string SQLquery = @"Select * from paciente";
                DataSet mDataSet = new DataSet();
                MySqlDataAdapter mDataAdapter = new MySqlDataAdapter(SQLquery, mConn);
                mDataAdapter.Fill(mDataSet, "Tabela Paciente");
                dataPaciente_Admin.DataSource = mDataSet;
                dataPaciente_Admin.DataMember = "Tabela Paciente";

                mConn.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNovoMedico_Click(object sender, EventArgs e)
        {
            mConn.Open();
            if (mConn.State == ConnectionState.Open)
            {
                //Obtenção do índice do item da comboBox (como a contagem inicia em 0 soma-se 1) 
               int especialidade = Convert.ToInt16(comboEspecialidade.SelectedIndex)+1;
                //inserir valores na tabela medico
               string SQLquery = "INSERT INTO medico VALUES('" + txtID_medico.Text + "','" + txtPass.Text +
                                   "','" + txtNome.Text + "','" + txtTelef.Text + "','" + "M" + "','" + especialidade.ToString() + "')";

                MySqlCommand mCommand = new MySqlCommand(SQLquery, mConn);
                mCommand.ExecuteNonQuery();

                //informa o administrativo de que os dados foram inseridos corretamente
                MessageBox.Show("Dados inseridos com sucesso!");
                 
                mConn.Close();

                Atualizar_MenuAdministrativo();
            }

            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //atualiza a Data MÉDICOS com os novos dados ou remoçao destes
        void Atualizar_Data_Medicos()
        {
            mConn.Open();

            if (mConn.State == ConnectionState.Open)
            {
                string SQLquery = @"Select medico.idMedico, medico.Passwrd, medico.Nome, medico.Telefone, especialidade.idEspecialidade as 'ID Especialidade', especialidade.Designacao as 'Especialidade' 
                From medico, especialidade where medico.idEspecialidade = especialidade.idEspecialidade and especialidade.idEspecialidade = medico.idEspecialidade order by medico.idMedico";
                
                DataSet mDataSet = new DataSet();
                MySqlDataAdapter mDataAdapter = new MySqlDataAdapter(SQLquery, mConn);
                mDataAdapter.Fill(mDataSet, "Tabela Médico");
                dataMedico_Admin.DataSource = mDataSet;
                dataMedico_Admin.DataMember = "Tabela Médico";

                mConn.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Preenche as textBoxes com as informações seleccionadas
        private void dataMedico_Admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID_medico.Text = dataMedico_Admin.SelectedRows[0].Cells[0].Value.ToString();
            txtPass.Text = dataMedico_Admin.SelectedRows[0].Cells[1].Value.ToString();
            txtNome.Text = dataMedico_Admin.SelectedRows[0].Cells[2].Value.ToString();
            txtTelef.Text = dataMedico_Admin.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void btDespedirMedico_Click(object sender, EventArgs e)
        {
            mConn.Open();
            if (mConn.State == ConnectionState.Open)
            {
                //remover valores na tabela medico
                string SQLquery = "Delete from medico where idMedico = " + txtID_medico.Text + ";";

                MySqlCommand mCommand = new MySqlCommand(SQLquery, mConn);
                mCommand.ExecuteNonQuery();

                //informa o administrativo de que os dados foram inseridos corretamente
                MessageBox.Show("Dados removidos com sucesso!");

                mConn.Close();

                Atualizar_MenuAdministrativo();

            }

            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataPaciente_Admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDPaciente.Text = dataPaciente_Admin.SelectedRows[0].Cells[0].Value.ToString();
            txtInserirNomePaciente.Text = dataPaciente_Admin.SelectedRows[0].Cells[1].Value.ToString();
            txtMoradaPaciente.Text = dataPaciente_Admin.SelectedRows[0].Cells[2].Value.ToString();
            
        }

        private void btNovoPaciente_Click(object sender, EventArgs e)
        {
            mConn.Open();
            if (mConn.State == ConnectionState.Open)
            {

                //inserir valores na tabela medico
                string SQLquery = "INSERT INTO paciente VALUES('" + txtIDPaciente.Text + "','" + txtInserirNomePaciente.Text +
                                    "','" + txtMoradaPaciente.Text + "')";

                MySqlCommand mCommand = new MySqlCommand(SQLquery, mConn);
                mCommand.ExecuteNonQuery();

                //informa o administrativo de que os dados foram inseridos corretamente
                MessageBox.Show("Dados inseridos com sucesso!");

                mConn.Close();

                Atualizar_MenuAdministrativo();
            }

            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btModificarPaciente_Click(object sender, EventArgs e)
        {
            mConn.Open();
            if (mConn.State == ConnectionState.Open)
            {

                //Update valores na tabela paciente
                string SQLquery = "Update paciente Set Nome = '" + txtInserirNomePaciente.Text + "', Morada = '" + txtMoradaPaciente.Text + "' where idPaciente = '"+ txtIDPaciente.Text +"'";
                MySqlCommand mCommand = new MySqlCommand(SQLquery, mConn);
                mCommand.ExecuteNonQuery();

                //informa o administrativo de que os dados foram inseridos corretamente
                MessageBox.Show("Dados modificados com sucesso!");

                mConn.Close();

                Atualizar_MenuAdministrativo();
            }

            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelarConsulta_Click(object sender, EventArgs e)
        {
            
            
            mConn.Open();
            if (mConn.State == ConnectionState.Open)
            {

                string SQLquery = "Delete from consulta where idPaciente = '"+ txtID_Paciente_Consulta.Text + " and Data = "+ txt_Data_Consulta.Text +"'"; 

                MySqlCommand mCommand = new MySqlCommand(SQLquery, mConn);
                mCommand.ExecuteNonQuery();

                //informa o administrativo de que os dados foram inseridos corretamente
                MessageBox.Show("Dados removidos com sucesso!");

                mConn.Close();
                Atualizar_MenuAdministrativo();

            }

            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Apresenta nas TextBoxes o ID do paciente e a data da consulta seleccionada
        private void dataConsulta_Admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID_Paciente_Consulta.Text = dataConsulta_Admin.SelectedRows[0].Cells[0].Value.ToString();
            txt_Data_Consulta.Text = dataConsulta_Admin.SelectedRows[0].Cells[3].Value.ToString();
        }
        //Apresenta na TextBox o ID do médico diretor da especialidade para que este possa ser alterado
        private void dataEspecialidade_Admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDMedicoDir.Text = dataEspecialidade_Admin.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btAlterarDiretor_Click(object sender, EventArgs e)
        {
            mConn.Open();
            if (mConn.State == ConnectionState.Open)
            {

                //Update valores na tabela especialidade -> Altera o ID do Médico Diretor da especialidade
                string SQLquery = "Update especialidade Set MedicoDiretor = '" + txtIDMedicoDir.Text + "' where Designacao = '" + dataEspecialidade_Admin.SelectedRows[0].Cells[0].Value.ToString() + "'";
                MySqlCommand mCommand = new MySqlCommand(SQLquery, mConn);
                mCommand.ExecuteNonQuery();

                //informa que os dados foram inseridos corretamente
                MessageBox.Show("Dados modificados com sucesso!");

                mConn.Close();

                Atualizar_MenuAdministrativo();
            }

            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            Atualizar_Consultas();
        }

        //Estatisticas 
        private void btEstaticOK_Click(object sender, EventArgs e)
        {
            int opcaoCombo = Convert.ToInt16(comboEstatic.SelectedIndex);

            switch (opcaoCombo)
            {
                case 0:  mConn.Open();
                        if (mConn.State == ConnectionState.Open)
                        {
                            string SQLquery = @"Select count(consulta.idMedico) as 'Total de Consultas', medico.Nome as 'Médico(a)' from consulta, medico 
                            where  consulta.idMedico = medico.idMedico group by consulta.idMedico limit 2";
                            DataSet mDataSet = new DataSet();
                            MySqlDataAdapter mDataAdapter = new MySqlDataAdapter(SQLquery, mConn);
                             mDataAdapter.Fill(mDataSet, "Tabela Estatística_Medico");
                            dataEstatistica.DataSource = mDataSet;
                            dataEstatistica.DataMember = "Tabela Estatística_Medico";

                            mConn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                case 1: mConn.Open();
                    if (mConn.State == ConnectionState.Open)
                        {
                            string SQLquery = @"Select count(consulta.Data) as 'Total de Consultas', consulta.Data, medico.Nome from consulta, medico 
                            where consulta.idMedico = medico.idMedico group by consulta.idMedico order by count(consulta.Data) DESC limit 1";
                            DataSet mDataSet = new DataSet();
                            MySqlDataAdapter mDataAdapter = new MySqlDataAdapter(SQLquery, mConn);
                            mDataAdapter.Fill(mDataSet, "Tabela Estatística_Data");
                            dataEstatistica.DataSource = mDataSet;
                            dataEstatistica.DataMember = "Tabela Estatística_Data";

                            mConn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } break;

                default: MessageBox.Show("Escolha uma opção!");
                    break;
            }


        }

        //Ver consultas de um determinado paciente
        private void btVer_Click(object sender, EventArgs e)
        {
            string paciente_ver = dataPaciente_Estatic.SelectedRows[0].Cells[0].Value.ToString();

            mConn.Open();

            if (mConn.State == ConnectionState.Open)
            {
                string SQLquery = @"Select count(*) as 'Consultas marcadas' from consulta, paciente where consulta.idPaciente = paciente.idPaciente and paciente.Nome = '"+ paciente_ver +"'";
                DataSet mDataSet = new DataSet();
                MySqlDataAdapter mDataAdapter = new MySqlDataAdapter(SQLquery, mConn);
                mDataAdapter.Fill(mDataSet, "Tabela Paciente_Consultas");
                dataTotalConsultas.DataSource = mDataSet;
                dataTotalConsultas.DataMember = "Tabela Paciente_Consultas";

                mConn.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Atualiza a Data com o nome dos pacientes
        private void Atualizar_Pacientes_Estatic()
        {
            mConn.Open();

            if (mConn.State == ConnectionState.Open)
            {
                string SQLquery = @"Select Nome as 'Paciente' from paciente";
                DataSet mDataSet = new DataSet();
                MySqlDataAdapter mDataAdapter = new MySqlDataAdapter(SQLquery, mConn);
                mDataAdapter.Fill(mDataSet, "Tabela Paciente");
                dataPaciente_Estatic.DataSource = mDataSet;
                dataPaciente_Estatic.DataMember = "Tabela Paciente";

                mConn.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btIntervalo_Click(object sender, EventArgs e)
        {
            if (checkAgrupar.Checked == true)
            {
                mConn.Open();

                if (mConn.State == ConnectionState.Open)
                {
                    string SQLquery = @"select count(*) as 'Nº de Consultas', medico.Nome as 'Médico(a)' from consulta, medico where consulta.idMedico=medico.idMedico and time(Data) between  '"+comboTempoInicial.Text+"' and '"+comboTempoFinal.Text+"' group  by medico.idMedico";
                    DataSet mDataSet = new DataSet();
                    MySqlDataAdapter mDataAdapter = new MySqlDataAdapter(SQLquery, mConn);
                    mDataAdapter.Fill(mDataSet, "Tabela Contagem");
                    dataConsultaTempo.DataSource = mDataSet;
                    dataConsultaTempo.DataMember = "Tabela Contagem";

                    mConn.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                mConn.Open();

                if (mConn.State == ConnectionState.Open)
                {
                    string SQLquery = @"Select count(*) as 'Nº de Consultas' from consulta where time(Data) between '"+comboTempoInicial.Text+"' and '"+comboTempoFinal.Text+"'";
                    DataSet mDataSet = new DataSet();
                    MySqlDataAdapter mDataAdapter = new MySqlDataAdapter(SQLquery, mConn);
                    mDataAdapter.Fill(mDataSet, "Tabela Contagem");
                    dataConsultaTempo.DataSource = mDataSet;
                    dataConsultaTempo.DataMember = "Tabela Contagem";

                    mConn.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
