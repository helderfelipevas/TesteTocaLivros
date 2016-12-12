using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoTesteTocaLivros.Model.Bean;

namespace ProjetoTesteTocaLivros.View
{
    public partial class NovoUsuario : Form
    {
        public NovoUsuario()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtNome.Text != "" && txtEmail.Text != "" && txtEndereco.Text != "")
                {
                    BeanUsuario bean = new BeanUsuario();

                    bean.setNome(txtNome.Text);
                    bean.setEmail(txtEmail.Text);
                    bean.setEndereco(txtEndereco.Text);

                    bean.CadastrarUsuario();

                    limparCampos();

                    MessageBox.Show("Cadastro realizado com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Preencha todos os Campos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("O seguinte erro ocorreu: "+ ex);
            }
            
        }

        void limparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
        }
    }
}
