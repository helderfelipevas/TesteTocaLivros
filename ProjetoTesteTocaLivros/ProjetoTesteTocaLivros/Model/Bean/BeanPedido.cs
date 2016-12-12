using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteTocaLivros.Model.Bean
{
    class BeanPedido
    {
        private int cdPedido;
        private String nmProduto;
        private Double vlProduto;
        private int qtProduto;
        private int cdUsuario;

        Double vTotal;

        public int getCodigo()
        {
            return cdPedido;
        }
        public void setCodigo(int cdPedido)
        {
            this.cdPedido = cdPedido;
        }

        public string getNomeProduto()
        {
            return nmProduto;
        }
        public void setNomeProduto(string nmProduto)
        {
            this.nmProduto = nmProduto;
        }

        public double getValorProduto()
        {
            return vlProduto;
        }
        public void setValorProduto(double vlProduto)
        {
            this.vlProduto = vlProduto;
        }

        public int getQuantProduto()
        {
            return qtProduto;
        }
        public void setQuantProduto(int qtProduto)
        {
            this.qtProduto = qtProduto;
        }

        public int getCodigoUsuario()
        {
            return cdUsuario;
        }
        public void setCodigoUsuario(int cdUsuario)
        {
            this.cdUsuario = cdUsuario;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=HELDERFELIPE-PC\SQLEXPRESS;Initial Catalog=tocaLivros;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public void buscarPedido(int codigo)
        {
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "SELECT * FROM Pedido WHERE cd_usuario =" + codigo + "";

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                setCodigo(Convert.ToInt32(dr["cd_usuario"].ToString()));
                setNomeProduto(dr["nm_produto"].ToString());
                setValorProduto(Convert.ToDouble(dr["vl_produto"].ToString()));
                setQuantProduto(Convert.ToInt32(dr["qt_produto"].ToString()));
                setCodigoUsuario(Convert.ToInt32(dr["cd_usuario_USUARIO"].ToString()));
            }

            conn.Close();
        }

        public void ExcluirPedido(int codigo)
        {
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "DELETE FROM Pedido WHERE cd_pedido =" + codigo + "";

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public void CadastrarPedido()
        {
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "INSERT INTO Pedido (nm_Produto, vl_produto, qt_produto, cd_usuario_USUARIO) VALUES ('" + getNomeProduto() + "','" + getValorProduto() + "','" + getQuantProduto() + "','" + getCodigoUsuario() + "')";

            cmd.ExecuteNonQuery();
            cmd.Clone();
            conn.Close();
        }

        //public Double ValorTotal(int codigo)
        //{

            //cmd.Connection = conn;
            //conn.Open();

            //cmd.CommandText = "SELECT vl_produto FROM Pedido WHERE cd_usuario =" + codigo + "";

            //dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
                
            //    vTotal =+ Convert.ToDouble(dr["vl_produto"].ToString()); 
            //    return vTotal;
            //}

            //return vTotal;
        //}
    }
}
