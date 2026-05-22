using CadastroClientes.Models;
using CadastroClientes.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadastroClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpPost("Salvar")]
        public object Salvar([FromBody] Clientes cadastro)
        {
            try
            {
                ClientesRepository clientes = new ClientesRepository(null);
                clientes.Salvar(cadastro);
            }
            catch (Exception ex)
            {

                throw;
            }
            return null;
        }

        [HttpPut("Alterar")]
        public object Alterar([FromBody] Clientes cadastro)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
            return null;
        }

        [HttpGet("Listar")]
        public object Listar()
        {
            List<Clientes> listaCliente = null;
            try
            {
                ClientesRepository clientesRepository = new ClientesRepository(null);
                listaCliente = clientesRepository.Listar();

            }
            catch (Exception ex)
            {

                throw;
            }
            return listaCliente;
        }

        [HttpDelete("Deletar")]
        public object Deletar(string Documento)
        {
            try
            {
                ClientesRepository clientesRepository = new ClientesRepository(null);
                bool retornoDeletar = clientesRepository.Deletar(Documento);

                return retornoDeletar;
            }
            catch (Exception ex)
            {

                throw;
            }
            return null;
        }

        [HttpDelete("GetCliente")]
        public object GetCliente(string Documento)
        {
            try
            {
                ClientesRepository clientesRepository = new ClientesRepository(null);
                var returno  = clientesRepository.GetCliente(Documento);
                return returno;
            }
            catch (Exception ex)
            {

                throw;
            }
            return null;
        }


    }
}
