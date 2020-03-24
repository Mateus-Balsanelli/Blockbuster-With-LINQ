using System;
using DataBase;

namespace Controllers{

    public class Cliente{
        static Boolean validacao = false;
        static DateTime nascimento = DateTime.Now;
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
    }
}