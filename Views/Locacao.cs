using System;
using System.Collections.Generic;
using System.Linq;
using DataBase;

namespace Views{

    public class Locacao {

        ///<summary> Register a new location "menu"  </summary>
        public static void cadastrarLocacao(){
        
            Console.WriteLine("Cadastro de locação");
            Console.WriteLine("-------------------");
            Console.WriteLine("Insira a data de Locação");
            DateTime dataLocacao =  DateTime.Now;
            DateTime dataDevolucao = Controller.Locacao.validarData();
            Console.WriteLine("Insira o ID do cliente");
            int idCliente =  Controller.Cliente.pesquisarCliente();
            Console.WriteLine("Favor insira os filmes que serão locados");
            List<Models.Filme> filmesLocados = Controller.Locacao.cadastrarLocacaoFilmes();
            Controller.Locacao.cadastrarLocacao(dataLocacao,dataDevolucao,idCliente,filmesLocados);

        }

        ///<summary> Serch for especific location "menu"  </summary>
        public static void pesquisarFilme(){
            System.Console.WriteLine("Menu de Busca de locacao");
            System.Console.WriteLine("Insira o ID da locação");
            int id = Int32.Parse(Console.ReadLine());
            IEnumerable<Models.Locacao> clienteQuery =
                from objeto in Db.Locacaos()
                where objeto.idLocacao == id
                select objeto;
            foreach(Models.Locacao locacao in clienteQuery)  {
                System.Console.WriteLine(locacao.filmesLocados);
            } 
        }    
    }
}