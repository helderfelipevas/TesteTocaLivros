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
    public partial class Usuario : Form
    {
        public Usuario(int codigo)
        {
            InitializeComponent();

            BeanUsuario bean = new BeanUsuario();
            bean.buscarUsuario(codigo);
            lblNome.Text = bean.getNome();
            lblEmail.Text = bean.getEmail();
            lblEndereco.Text = bean.getEndereco();
            lblCodigo.Text = Convert.ToString(bean.getCodigo());
        }

        public Usuario()
        {
            // TODO: Complete member initialization
        }

        BeanUsuario bean = new BeanUsuario();

        private void Usuario_Load(object sender, EventArgs e)
        {
            

            

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
           ListarUsuarios lista = new ListarUsuarios();
            lista.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lblEmail.Hide();
            lblEndereco.Hide();
            lblNome.Hide();

            btnEditar.Hide();
            btnPedido.Hide();
            btnVoltar.Hide();

            txtEmail.Visible = true;
            txtEndereco.Visible = true;
            txtNome.Visible = true;

            txtNome.Text = lblNome.Text;
            txtEmail.Text = lblEmail.Text;
            txtEndereco.Text = lblEndereco.Text;

            btnAlterar.Visible = true;
            btnExcluir.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            showHideCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Mesmo Excluir o Usuario?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                bean.ExcluirUsuario(Convert.ToInt32(lblCodigo.Text));
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Mesmo Alterar o Usuario?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (txtNome.Text != "" && txtEmail.Text != "" && txtEndereco.Text != "")
                    {

                        bean.setNome(txtNome.Text);
                        bean.setEmail(txtEmail.Text);
                        bean.setEndereco(txtEndereco.Text);

                        bean.AlterarUsuario(Convert.ToInt32(lblCodigo.Text));

                        showHideCampos();
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os Campos.");
                    }
                } catch(Exception ex){
                    MessageBox.Show("O seguinte erro ocorreu: "+ex);
                }
            }

        }

        public void showHideCampos()
        {
            txtEmail.Hide();
            txtEndereco.Hide();
            txtNome.Hide();

            btnVoltar.Visible = true;
            btnPedido.Visible = true;
            btnEditar.Visible = true;

            lblEmail.Visible = true;
            lblEndereco.Visible = true;
            lblNome.Visible = true;

            lblEmail.Text = txtEmail.Text;
            lblNome.Text = txtNome.Text;
            lblEndereco.Text = txtEndereco.Text;

            btnAlterar.Visible = false;
            btnCancelar.Visible = false;
            btnExcluir.Visible = false;
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            Pedidos pedido = new Pedidos(Convert.ToInt32(lblCodigo.Text));
            pedido.Show();
            this.Hide();
        }

        private void bntVisualizarPedidos_Click(object sender, EventArgs e)
        {
            ListaPedidos listaPedidos = new ListaPedidos(Convert.ToInt32(lblCodigo.Text));
            listaPedidos.Show();
            this.Hide();
        }

    }
}
