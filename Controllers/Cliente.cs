using System;
using DataBase;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Controller{

    public class Cliente {
        static Boolean validacao = false;
        static DateTime nascimento = DateTime.Now;

        /// <summary> Register a new customer </summary>
        public static void cadastrarCliente(string nome,DateTime dataNascimento,string cpf){
            Models.Cliente cliente = new Models.Cliente(Db.listaClientes.Count,nome,dataNascimento,cpf);
            Db.addCliente(cliente);
        }

        /// <summary> Validate DateTime format </summary>
        public static DateTime validarNascimentoCliente(){
            do{
                Console.WriteLine("Insira a data de nascimento do cliente no seguinte formato => (dd/mm/yyyy)");
                string validaNascimento = Console.ReadLine();
                try{
                    nascimento = Convert.ToDateTime(validaNascimento);
                    validacao = true;
                } catch {
                    Console.WriteLine("O formato da data está incorreto tente novamente");
                    validacao = false;
                }   
            }while(validacao == false);
            return nascimento;
        }

        /// <summary> show the list of customers  </summary>
        public static int pesquisarCliente(){
            int opcaoCliente = 0;
            Models.Cliente cliente = null;
            do{
                Console.WriteLine("Informe o id do cliente");
                opcaoCliente = Convert.ToInt32(Console.ReadLine());
                try{
                    cliente = Db.listaClientes.Find(cliente => cliente.idCliente == opcaoCliente);
                    if (cliente == null){
                        Console.WriteLine("cliente não localizado");
                    }
                }catch{
                    Console.WriteLine("cliente não localizado");
                }
            }while(cliente == null);
            return opcaoCliente;
        }

        /// <summary> Search for especific customer </summary>
        public static void pesquisarClienteEspecifico(){
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