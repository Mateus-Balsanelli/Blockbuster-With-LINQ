using System;
using System.Collections.Generic;
using System.Linq;
using DataBase;
using Models;


namespace Views{

    public class Cliente{

        public static void cadastrarCliente(){

            Console.WriteLine("Cadastro de cliente");
            Console.WriteLine("-------------------");
            Console.WriteLine("Insira o nome do cliente");
            string nome = Console.ReadLine();            
            Console.WriteLine("Insira o CPF do cliente");
            string cpf = Console.ReadLine();
            DateTime nascimento = Controllers.Cliente.validarNascimentoCliente();
            Models.Cliente.cadastrarCliente(nome,nascimento,cpf);     
        }
        public static void pesquisarCliente(){
            System.Console.WriteLine("Menu de Busca cliente");
            System.Console.WriteLine("Insira o ID do cliente");
            int id = Int32.Parse(Console.ReadLine());
            IEnumerable<Models.Cliente> clienteQuery =
                from objeto in Db.Clientes()
                where objeto.idCliente == id
                select objeto;
            foreach(Models.Cliente cliente in clienteQuery)  {
                System.Console.WriteLine(cliente.nomeCliente);
            }      
        }            
    }
}