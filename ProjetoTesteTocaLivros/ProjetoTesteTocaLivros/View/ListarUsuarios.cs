using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoTesteTocaLivros.Model.Bean;


namespace ProjetoTesteTocaLivros.View
{
    public partial class ListarUsuarios : Form
    {
        public ListarUsuarios()
        {
            InitializeComponent();        
        }

            SqlConnection conn = new SqlConnection(@"Data Source=HELDERFELIPE-PC\SQLEXPRESS;Initial Catalog=tocaLivros;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;


           
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void ListarUsuarios_Load(object sender, EventArgs e)
        {
            lbUsuarios.Items.Clear();

            try
            {

                cmd.Connection = conn;
                conn.Open();

                cmd.CommandText = "SELECT * FROM Usuario";

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lbUsuarios.Items.Add(dr[0].ToString() + " | " + dr[1].ToString());
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("O seguinte erro ocorreu: " + ex);
            }
        }

        private void lbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuarios.SelectedItem.ToString();
            string[] colunas = usuario.Split('|');
            int codigo = Convert.ToInt32(colunas[0]);

            Usuario usuarioTela = new Usuario(codigo);
            usuarioTela.Show();
            this.Hide();
        }
    }
}
