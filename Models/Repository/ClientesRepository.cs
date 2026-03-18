using System.Collections.Generic;

namespace CadastroClientes.Models.Repository
{
    public class ClientesRepository
    {
        public List<Clientes> Listar() 
        {
            List<Clientes> clientesLista = new List<Clientes>();

            //Instancia cliente Luiz Carlos
            Clientes cliente = new Clientes();
            cliente.UF = "SP";
            cliente.Fax = "1111111";
            cliente.Telefone = "2222222";
            cliente.Documento = "333333333";
            cliente.Email = "luiz@gmail.com";
            cliente.Nome = "Luiz Carlos";
            cliente.Sexo = "Masculino";
            cliente.IdCliente = 10;
            //Adicionando Luiz Carlos na lista de cliente
            clientesLista.Add(cliente);

            //Instancia cliente Jorge Ferreira
            cliente = new Clientes();
            cliente.UF = "MG";
            cliente.Fax = "4444444";
            cliente.Telefone = "5555555";
            cliente.Documento = "6666666";
            cliente.Email = "jorge@gmail.com";
            cliente.Nome = "Jorge Ferreira";
            cliente.Sexo = "Masculino";
            cliente.IdCliente = 22;
            //Adicionando Jorge Ferreira na lista de cliente
            clientesLista.Add(cliente);

            //Instancia cliente Maria da Silva
            cliente = new Clientes();
            cliente.UF = "RJ";
            cliente.Fax = "7777777";
            cliente.Telefone = "88888";
            cliente.Documento = "999999";
            cliente.Email = "maria@gmail.com";
            cliente.Nome = "Maria da Silva";
            cliente.Sexo = "Feminino";
            cliente.IdCliente = 33;
            //Adicionando Maria da Silva na lista de cliente
            clientesLista.Add(cliente);

            return clientesLista;
        }
    }
}
