using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteTocaLivros.Model.Bean
{
    class BeanUsuario
    {
        private int cdUsuario;
        private String nmUsuario;
        private String dsEmail;
        private String dsEndereco;

        public int getCodigo()
        {
            return cdUsuario;
        }
        public void setCodigo(int cdUsuario)
        {
            this.cdUsuario = cdUsuario;
        }

        public string getNome()
        {
            return nmUsuario;
        }
        public void setNome(string nmUsuario)
        {
            this.nmUsuario = nmUsuario;
        }

        public string getEmail()
        {
            return dsEmail;
        }
        public void setEmail(string dsEmail)
        {
            this.dsEmail = dsEmail;
        }

        public string getEndereco()
        {
            return dsEndereco;
        }
        public void setEndereco(string dsEndereco)
        {
            this.dsEndereco = dsEndereco;
        }
        //public String nome { get; set; }
        //public String nome { get { return nmUsuario; } set { nmUsuario = value; } }

        SqlConnection conn = new SqlConnection(@"Data Source=HELDERFELIPE-PC\SQLEXPRESS;Initial Catalog=tocaLivros;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public void buscarUsuario(int codigo)
        {
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "SELECT * FROM Usuario WHERE cd_usuario =" + codigo + "";

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                setCodigo(Convert.ToInt32(dr["cd_usuario"].ToString()));
                setNome(dr["nm_usuario"].ToString());
                setEmail(dr["ds_email"].ToString());
                setEndereco(dr["ds_endereco"].ToString());

            }

            conn.Close();
        }

        public void ExcluirUsuario(int codigo)
        {
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "DELETE FROM Usuario WHERE cd_usuario =" +codigo+ "";

            cmd.ExecuteNonQuery();

            conn.Close();
  
        }

        public void AlterarUsuario(int codigo)
        {
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "UPDATE Usuario SET nm_usuario = @nome, ds_email = @email, ds_endereco = @endereco WHERE cd_usuario = "+codigo+"";

            cmd.Parameters.AddWithValue("@nome",getNome());
            cmd.Parameters.AddWithValue("@email",getEmail());
            cmd.Parameters.AddWithValue("@endereco",getEndereco());

            cmd.ExecuteNonQuery();

                conn.Close();
        }

        public void CadastrarUsuario()
        {
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "INSERT INTO Usuario (nm_usuario, ds_email, ds_endereco) VALUES ('" + getNome() + "','" + getEmail() + "','" + getEndereco() + "')";
            
            cmd.ExecuteNonQuery();
            cmd.Clone();
            conn.Close();
        }
    }
}
