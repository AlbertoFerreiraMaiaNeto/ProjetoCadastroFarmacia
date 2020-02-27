using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaPagueMenos.DAO
{
    class LoginDaoComandos
    {
        public bool tem;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Connection con = new Connection();
        SqlDataReader dr;
        public bool verificarLogin(string cpf, string senha)
        {
            //COMANDOS SQL PARA VERIFICAR SE TEM NO BANCO
            cmd.CommandText = "select * from Cliente where cpf = @cpf and senha =@senha";
            cmd.Parameters.AddWithValue(@"cpf", cpf);
            cmd.Parameters.AddWithValue(@"senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";
            }
            return tem;

        }

        public string Cadastrar(string nome, string cpf, string senha, string confSenha)
        {
            tem = false;

            if (nome.Length == 0 || cpf.Length == 0 || senha.Length == 0 || confSenha.Length == 0)
            {
                this.mensagem = "Todos os campos são obrigatórios";
            }

            else if (cpf.Length != 11 && cpf.Length > 0)
            {
                this.mensagem = "Digite um CPF válido!";
            }

            else if (senha.Length < 8 && confSenha.Length < 8 && senha.Length > 0 && confSenha.Length > 0)
            {
                this.mensagem = "Sua senha precisa conter no mínimo 8 caracteres";
            }
            //COMANDOS PARA INSERIR NO BANCO E RETORNAR MENSAGEM
            else if (senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into Cliente values(@n,@c,@s);";
                cmd.Parameters.AddWithValue(@"n", nome);
                cmd.Parameters.AddWithValue(@"c", cpf);
                cmd.Parameters.AddWithValue(@"s", senha);
                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com Sucesso!";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com o Banco de Dados";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem.";
            }
            return mensagem;
        }
    }
}
