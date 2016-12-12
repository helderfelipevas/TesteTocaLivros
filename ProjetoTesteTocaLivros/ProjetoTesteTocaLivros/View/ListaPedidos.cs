using ProjetoTesteTocaLivros.Model.Bean;
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

namespace ProjetoTesteTocaLivros.View
{
    public partial class ListaPedidos : Form
    {
        public ListaPedidos(int codigoUsuario)
        {
            InitializeComponent();
            lblCodigo.Text = Convert.ToString(codigoUsuario);
            
        }
            SqlConnection conn = new SqlConnection(@"Data Source=HELDERFELIPE-PC\SQLEXPRESS;Initial Catalog=tocaLivros;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            private double vTotal;
            

        private void ListaPedidos_Load(object sender, EventArgs e)
        {
            lbPedidos.Items.Clear();

            try
            {

                cmd.Connection = conn;
                conn.Open();

                cmd.CommandText = "SELECT * FROM Pedido WHERE cd_usuario_USUARIO =" + Convert.ToInt32(lblCodigo.Text) + "";

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lbPedidos.Items.Add(dr[0].ToString() + " | " + dr[1].ToString() + " | R$: " + dr[2].ToString() + " | Qt: " + dr[4].ToString());
                    }
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("O seguinte erro ocorreu: " + ex);
            }

            //Valor total
            
 
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "SELECT vl_produto, qt_produto FROM Pedido WHERE cd_usuario_USUARIO =" + Convert.ToInt32(lblCodigo.Text) + "";

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                vTotal = vTotal + ((Convert.ToDouble(dr["vl_produto"].ToString())) * Convert.ToInt32(dr["qt_produto"].ToString()));
                lblValorTotal.Text = Convert.ToString(vTotal) + " R$";
            }

            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario(Convert.ToInt32(lblCodigo.Text));
            usu.Show();
            this.Hide();
        }

        private void btnAPagarPedido_Click(object sender, EventArgs e)
        {
            string pedido = lbPedidos.SelectedItem.ToString();
            string[] colunas = pedido.Split('|');
            
            if (MessageBox.Show("Deseja Mesmo Excluir o Pedido <" + colunas[1] + ">?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                
                int codigo = Convert.ToInt32(colunas[0]);

                BeanPedido bean = new BeanPedido();
                bean.ExcluirPedido(codigo);

                Usuario usu = new Usuario(Convert.ToInt32(lblCodigo.Text));
                usu.Show();
                this.Hide();
                
            }
        }
    }
}
