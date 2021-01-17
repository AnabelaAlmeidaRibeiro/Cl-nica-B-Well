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
    public partial class Inserir_Médico : Form
    {
        private MySqlConnection mConn;

        public Inserir_Médico()
        {
            InitializeComponent();
            mConn = new MySqlConnection("Persist Security Info=False; server=localhost; database=clínica_bwell; uid=root;password=1234");
        }

        private void btInserirMedico_Click(object sender, EventArgs e)
        {
            mConn.Open();


            if (mConn.State == ConnectionState.Open)
            {
                string radioEsp;

                if (radioPsic.Checked == true)
                {
                    radioEsp = "1";
                }
                else
                {
                    if (radioOftal.Checked == true)
                    {
                        radioEsp = "2";
                    }
                    else
                    {
                        if (radioDerma.Checked == true)
                        {
                            radioEsp = "3";
                        }
                        else
                        {
                            MessageBox.Show("Por favor escolha uma especialidade!");
                        }
                    }
                }

                //query SQL para inserir o novo filme 
                //int max_id = Convert.ToInt16(@"Select max(idMedico) from medico") + 1;
                string SQLquery = "INSERT INTO medico VALUES(" + "10" + "," + txtPass.Text + "," + txtNome_Medico.Text + ",'" + txt_Telef_Medico.Text +
                                    "'," + "M" + "," + "psicologia" + ");";

                MySqlCommand mCommand = new MySqlCommand(SQLquery, mConn);
                mCommand.ExecuteNonQuery();

                mConn.Close();



                Close();

            }
        

      

        }
    }
}
