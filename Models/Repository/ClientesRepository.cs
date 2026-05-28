using Microsoft.Data.SqlClient;
using System.Data;
using System.Net;

namespace CadastroClientes.Models.Repository
{
    public class ClientesRepository
    {
        private AppConnection _appConfig;

        public ClientesRepository(AppConnection appConfig)
        {
            _appConfig = appConfig;
        }

        public void Salvar(Clientes clientes)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => false;

                using (SqlConnection connection = new SqlConnection(_appConfig.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("PROC_INSERIR_CLIENTES", connection))
                    { 
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdCliente", clientes.IdCliente);
                        cmd.Parameters.AddWithValue("@Documento", clientes.Documento);
                        cmd.Parameters.AddWithValue("@Nome", clientes.Nome);
                        cmd.Parameters.AddWithValue("@Sexo", clientes.Sexo);
                        cmd.Parameters.AddWithValue("@Email", clientes.Email);
                        cmd.Parameters.AddWithValue("@Telefone", clientes.Telefone);
                        cmd.Parameters.AddWithValue("@Fax", clientes.Fax);
                        cmd.Parameters.AddWithValue("@UF", clientes.UF);

                        cmd.ExecuteNonQuery();
                    }
                }
            }  
            catch (Exception ex)
            {

            }
        }

        public void Atualizar(Clientes clientes)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_appConfig.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("PROC_UPDATE_CLIENTES", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdCliente", clientes.IdCliente);
                        cmd.Parameters.AddWithValue("@Documento", clientes.Documento);
                        cmd.Parameters.AddWithValue("@Nome", clientes.Nome);
                        cmd.Parameters.AddWithValue("@Sexo", clientes.Sexo);
                        cmd.Parameters.AddWithValue("@Email", clientes.Email);
                        cmd.Parameters.AddWithValue("@Telefone", clientes.Telefone);
                        cmd.Parameters.AddWithValue("@Fax", clientes.Fax);
                        cmd.Parameters.AddWithValue("@UF", clientes.UF);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        public List<Clientes> Listar() 
        {
            List<Clientes> retorno = new List<Clientes>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_appConfig.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("PROC_LISTAR_CLIENTES", connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader()) 
                        {
                            while (reader.Read())
                            {
                                Clientes cliente = new Clientes();

                                cliente.IdCliente = Convert.ToInt32(reader["IdCliente"].ToString());
                                cliente.Documento = reader["Documento"].ToString();
                                cliente.Nome = reader["Nome"].ToString();
                                cliente.Sexo = reader["Sexo"].ToString();
                                cliente.Email = reader["Email"].ToString();
                                cliente.Telefone = reader["Telefone"].ToString();
                                cliente.Fax = reader["Fax"].ToString();
                                cliente.UF = reader["UF"].ToString();

                                retorno.Add(cliente);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return retorno;
        }

        public bool Deletar(int IdCliente)
        {
            bool retorno = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(_appConfig.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("PROC_DELETAR_CLIENTES", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdCliente", IdCliente);

                        int linhas = cmd.ExecuteNonQuery();

                        if (linhas > 0)                        
                            retorno = true;
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return retorno;
        }

        public Clientes? GetCliente(int IdCliente)
        {
            Clientes cliente = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(_appConfig.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("PROC_GET_CLIENTE", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdCliente", IdCliente);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cliente = new Clientes();

                                cliente.IdCliente = Convert.ToInt32(reader["IdCliente"].ToString());
                                cliente.Documento = reader["Documento"].ToString();
                                cliente.Nome = reader["Nome"].ToString();
                                cliente.Sexo = reader["Sexo"].ToString();
                                cliente.Email = reader["Email"].ToString();
                                cliente.Telefone = reader["Telefone"].ToString();
                                cliente.Fax = reader["Fax"].ToString();
                                cliente.UF = reader["UF"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return cliente;
        }
    }
}
