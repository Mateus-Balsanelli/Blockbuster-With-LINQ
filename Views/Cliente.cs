using System;
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
    
    }
}