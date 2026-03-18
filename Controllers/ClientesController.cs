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

            }
            catch (Exception ex)
            {

                throw;
            }
            return null;
        }

        [HttpPost("Alterar")]
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
                ClientesRepository clientesRepository = new ClientesRepository();
                listaCliente = clientesRepository.Listar();

            }
            catch (Exception ex)
            {

                throw;
            }
            return listaCliente;
        }

        [HttpDelete("Deletar")]
        public object Deletar(int IdCliente)
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


    }
}
