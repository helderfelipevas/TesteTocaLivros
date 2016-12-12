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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            NovoUsuario Nu = new NovoUsuario();
            Nu.Show();
            this.Hide();
        }

        private void btnFazerPedido_Click(object sender, EventArgs e)
        {
            ListarUsuarios Lu = new ListarUsuarios();
            Lu.Show();
            this.Hide();
        }
    }
}
