using System;
using System.Collections.Generic;
using DataBase;
using Controllers;


namespace Models {
    public class Locacao {

        public int idLocacao { get; set; }

        public DateTime dataLocacao { get; set;}

        public DateTime dataDevolucao { get; set; }

        public int idCliente { get; set; }

        public List<Filme> filmesLocados { get; set; }


        public Locacao(int idLocacao, DateTime dataLocacao, DateTime dataDevolucao, int idCliente, List<Filme> filmesLocados ){
            this.idLocacao = idLocacao;
            this.dataLocacao = dataLocacao;
            this.dataDevolucao = dataDevolucao;
            this.idCliente = idCliente;
            this.filmesLocados = filmesLocados;
            Db.addLocacao(this);

        }

        public static void cadastrarLocacao(DateTime dataLocacao, DateTime dataDevolucao, int idCliente, List<Filme> filmesLocados){
            Locacao locacao = new Locacao(Db.listaLocacaos.Count,dataLocacao,dataDevolucao,idCliente,filmesLocados);
            Db.addLocacao(locacao);
        }

        public string ToString(Boolean aux =false){
            string retorno = $"Id :{idLocacao} # Data Locação:{dataLocacao} # Data de Devolução:{dataDevolucao} # ID do cliente:{idCliente} # Filmes locados:{filmesLocados}";
            return retorno; 
        }

        public static List<Models.Filme> cadastrarLocacaoFilmes(){
            int opcao = 1;
            Models.Filme filme = null;
            List<Models.Filme> filmeslocados = new List<Models.Filme>();
            do{
                filme = null;
                Console.WriteLine("Cadastrar filmes que serão locados");
                Console.WriteLine("Esolha uma opção");
                Console.WriteLine("[1] Adicionar um filme a essa locação");
                Console.WriteLine("[2] Terminar Locação");
                opcao = Int32.Parse(Console.ReadLine());
                switch(opcao){
                    case 1:
                    filme = Controllers.Filme.pesquisarFilme();
                    filmeslocados.Add(filme);
                    break;
                    case 2:
                    opcao = 2;
                    break;
                }
                
            }while(opcao == 1);
            return filmeslocados;
        }


        
    }
}