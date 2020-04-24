using System;
using DataBase;

namespace Models{

    public class Cliente {
                      
        public int idCliente { get; set; }

        public string nomeCliente { get; set; }
        
        public DateTime dataNascimento { get; set; }

        public string cpf { get; set; }

        public Cliente (int id,string nomeCliente,DateTime dataNascimento,string cpf){
            this.idCliente = id;
            this.nomeCliente = nomeCliente;
            this.dataNascimento = dataNascimento;
            this.cpf = cpf;
        }
/*
        public static void cadastrarCliente(string nome,DateTime dataNascimento,string cpf){
            Cliente cliente = new Cliente(Db.listaClientes.Count,nome,dataNascimento,cpf);
            Db.addCliente(cliente);
        }
*/
        public string ToString(Boolean aux = false){
            string retorno = $"Id:{idCliente} # Nome:{nomeCliente} # Data de Nascimetno:{dataNascimento} #  CPF:{cpf} ";
            return retorno;
        }
    }
}