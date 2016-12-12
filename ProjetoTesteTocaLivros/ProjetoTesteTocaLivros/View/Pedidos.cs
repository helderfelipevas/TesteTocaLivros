using ProjetoTesteTocaLivros.Model.Bean;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTesteTocaLivros.View
{
    public partial class Pedidos : Form
    {
        public Pedidos(int codigo)
        {
            InitializeComponent();

            lblCodigo.Text = Convert.ToString(codigo);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario(Convert.ToInt32(lblCodigo.Text));
            usu.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNomeProduto.Text != "" && txtValorProduto.Text != "" && txtQtProduto.Text != "")
                {
                    BeanPedido bean = new BeanPedido();

                    bean.setNomeProduto(txtNomeProduto.Text);
                    bean.setValorProduto(Convert.ToDouble(txtValorProduto.Text));
                    bean.setQuantProduto(Convert.ToInt32(txtQtProduto.Text));
                    bean.setCodigoUsuario(Convert.ToInt32(lblCodigo.Text));

                    bean.CadastrarPedido();

                    limparCampos();

                    MessageBox.Show("Pedido realizado com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("O seguinte erro ocorreu: " + ex);
            }
        }

        public void limparCampos()
        {
            txtNomeProduto.Clear();
            txtQtProduto.Clear();
            txtValorProduto.Clear();
        }
    }
}
