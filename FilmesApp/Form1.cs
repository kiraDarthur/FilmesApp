
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmesApp
{
    public partial class FormFilmes : Form
    {
        MySqlConnection conexao;

        public FormFilmes()
        {
            InitializeComponent();
        }

        private void FormFilmes_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            //Estabeler as a conexao a base de dados usando exceçoes
            try
            {
                string dataSource = txtDatasource.Text;
                string ultilizador = txtUtilizador.Text;
                string password = txtPassword.Text;
                int porta = int.Parse(txtPorta.Text);

                string connectionInfo = "datasource=" + dataSource + ";port=" + porta + ";username=" + ultilizador +
                    ";passaword=" + password + ";database=filmes_bd";

                conexao = new MySqlConnection(connectionInfo);
                
                conexao.Open();

                MessageBox.Show("A ligação foi estabelecida!");



            }
            catch (Exception ex)
            {

                MessageBox.Show(FormFilmes.ActiveForm, ex.Message, "Error!!!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
