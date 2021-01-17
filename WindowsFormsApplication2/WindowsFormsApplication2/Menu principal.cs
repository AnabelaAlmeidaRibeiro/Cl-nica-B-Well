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
    public partial class Form1 : Form
    {
        private MySqlConnection mConn;

        public Form1()
        {
            InitializeComponent();
            mConn = new MySqlConnection("Persist Security Info=False; server=localhost; database=clínica_bwell; uid=root;password=1234");
            
        }


        private void comboLogIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboLogIn.SelectedIndex == 0)
            {
                //Escreve na textBox do utilizador a letra correspondente ao tipo de funcionario
                txtUtilizador.Text = "A_";
            }
            else
            {
                if (comboLogIn.SelectedIndex == 1)
                {
                    //Escreve na textBox do utilizador a letra correspondente ao tipo de funcionario
                    txtUtilizador.Text = "M_";
                }
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Fecha a janela
            Close();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            //Guarda o índice da ComboBox para diferenciar o tipo de funcionario
            int login = Convert.ToInt16(comboLogIn.SelectedIndex);

            mConn.Open();
            if (login == 0)
            {
                //Obtenção do ID do Administrativo sem a letra do tipo de funcionario 
                string login_admin = txtUtilizador.Text;
                int posicao = login_admin.IndexOf("_");
                string id_admin = login_admin.Substring(posicao + 1, login_admin.Length - posicao - 1);

                

                if (mConn.State == ConnectionState.Open)
                {
                    //conta quantas linhas em que o ID e a Pass inseridos estão presentes na tabela Administrativo
                    string SQLquery = @"select count(*) from administrativo where idAdministrativo = '" + id_admin + "' and Password = '" + txtPass.Text + "'";
                    MySqlCommand mCommand = new MySqlCommand(SQLquery, mConn);
                    //Obtenção de um valor escalar da query anterior
                    int count_admin = Convert.ToInt32(mCommand.ExecuteScalar());

                    if (count_admin == 1)
                    {
                        MessageBox.Show("Login efetuado com sucesso!");
                        mConn.Close();
                        //Abre uma nova Form - Menu Administrativo
                        Menu_Administrativo f_admin = new Menu_Administrativo();
                        f_admin.ShowDialog();
                    }
                    else
                    {
                        if (count_admin == 0)
                        {
                            //Como count = 0 -> não há nenhuma correspondencia com a tabela Administrativo, o acesso é negado
                            MessageBox.Show("Utilizador ou Password incorretas! Tente outra vez!");
                            txtPass.Text = "";
                            mConn.Close();
                        }

                        else
                        {
                            MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } 
                }
           }
               
            else
            {
                if (login == 1)
                {
                    //Obtenção do ID do Utilizador Médico sem a sua letra de funcionário 
                    string login_medico = txtUtilizador.Text;
                    int posicao = login_medico.IndexOf("_");
                    string id_medico = login_medico.Substring(posicao + 1, login_medico.Length - posicao - 1);

                    
                    if (mConn.State == ConnectionState.Open)
                    {
                        //conta quantas linhas em que o ID e a Pass inseridos estão presentes na tabela Médico
                        string SQLquery = @"select count(*) from medico where idMedico = '" + id_medico + "' and Passwrd = '" + txtPass.Text + "'";
                        MySqlCommand mCommand = new MySqlCommand(SQLquery, mConn);
                        //Obtenção de um valor escalar da query anterior
                        int count_medico = Convert.ToInt32(mCommand.ExecuteScalar());

                        if (count_medico == 1)
                        {
                            MessageBox.Show("Login efetuado com sucesso!");
                            mConn.Close();
                            //Abre uma nova Form - Menu Administrativo
                            Menu_Medico f_med = new Menu_Medico();
                            f_med.ShowDialog();
                        }
                        else
                        {
                            if (count_medico == 0)
                            {
                                //Como count = 0 -> não há nenhuma correspondencia com a tabela Médico, o acesso é negado
                                MessageBox.Show("Utilizador ou Password incorretas! Tente outra vez!");
                                txtPass.Text = "";
                                mConn.Close();
                            }

                            else
                            {
                                MessageBox.Show("Não foi possível abrir a conexão à base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                  MessageBox.Show("Escolha a entidade!");
                }
            }
        }

        private void ToolEspecialidade_Click(object sender, EventArgs e)
        {
            //Abre uma Form que mostra as especialidades e os médicos
            Especialidades f2 = new Especialidades();
            f2.ShowDialog();
        }

        
    }
}
