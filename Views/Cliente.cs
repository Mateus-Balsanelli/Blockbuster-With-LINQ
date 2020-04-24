using System;
using System.Collections.Generic;
using System.Linq;
using DataBase;
using Controller;

namespace Views{

    public class Cliente{

        /// <summary> Register a new customer "menu" </summary>
        public static void cadastrarCliente(){

            Console.WriteLine("Cadastro de cliente");
            Console.WriteLine("-------------------");
            Console.WriteLine("Insira o nome do cliente");
            string nome = Console.ReadLine();            
            Console.WriteLine("Insira o CPF do cliente");
            string cpf = Console.ReadLine();
            DateTime nascimento = Controller.Cliente.validarNascimentoCliente();
            Controller.Cliente.cadastrarCliente(nome,nascimento,cpf);     
        }
        /// <summary> Search for especific customer "menu" </summary>
        public static void pesquisarCliente(){
            System.Console.WriteLine("Menu de Busca cliente");
            System.Console.WriteLine("Insira o ID do cliente");
            int id = Int32.Parse(Console.ReadLine());
            IEnumerable<Models.Cliente> clienteQuery =
                from objeto in Db.Clientes()
                where objeto.idCliente == id
                select objeto;
            foreach(Models.Cliente cliente in clienteQuery) {
                Console.WriteLine(cliente.idCliente);
                Console.WriteLine(cliente.nomeCliente);
                Console.WriteLine(cliente.dataNascimento);
                Console.WriteLine(cliente.cpf);
            }      
        }            
    }
}