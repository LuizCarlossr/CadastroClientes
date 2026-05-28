using CadastroClientes.Models;
using CadastroClientes.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CadastroClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        [HttpPost("Salvar")]
        public object Salvar([FromBody] Clientes cliente)
        {
            try
            {
                var appConfig = new AppConnection(configuration);

                

                ClientesRepository clientes = new ClientesRepository(appConfig);

                var returno = clientes.GetCliente(cliente.IdCliente);
                clientes.Salvar(cliente);

                if (returno != null) 
                {
                    clientes.Atualizar(cliente);
                }
                else
                    clientes.Salvar(cliente);
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        [HttpPut("Alterar")]
        public object Alterar([FromBody] Clientes cliente)
        {
            try
            {
                var appConfig = new AppConnection(configuration);

                ClientesRepository clientes = new ClientesRepository(appConfig);
                clientes.Atualizar(cliente);

            }
            catch (Exception ex)
            {

            }

            return null;
        }

        [HttpGet("Listar")]
        public object Listar()
        {
            List<Clientes> listaCliente = null;
            try
            {
                var appConfig = new AppConnection(configuration);

                ClientesRepository clientesRepository = new ClientesRepository(appConfig);
                listaCliente = clientesRepository.Listar();

            }
            catch (Exception ex)
            {

            }

            return listaCliente;
        }

        [HttpDelete("Deletar")]
        public object Deletar(int IdCliente)
        {
            try
            {
                var appConfig = new AppConnection(configuration);

                ClientesRepository clientesRepository = new ClientesRepository(appConfig);
                bool retornoDeletar = clientesRepository.Deletar(IdCliente);

                return retornoDeletar;
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        [HttpGet("GetCliente")]
        public object GetCliente(int IdCliente)
        {
            try
            {
                var appConfig = new AppConnection(configuration);

                ClientesRepository clientesRepository = new ClientesRepository(appConfig);
                var returno  = clientesRepository.GetCliente(IdCliente);
                return returno;
            }
            catch (Exception ex)
            {

            }

            return null;
        }
    }
}
