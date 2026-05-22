using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.Json.Serialization;

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
            return null;
        }

        public bool Deletar(string Documento)
        {
            return false;
        }

        public Clientes GetCliente(string Documento)
        {
            return null;
        }
    }
}
