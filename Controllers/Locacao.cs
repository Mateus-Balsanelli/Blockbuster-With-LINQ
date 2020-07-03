using System;
using System.Collections.Generic;
using DataBase;
using Models;

namespace Controller{

    public class Locacao {

        static Boolean validacao = false;

        static DateTime data = DateTime.Now;

        /// <summary> Register a new location </summary>
        public static void cadastrarLocacao(DateTime dataLocacao, DateTime dataDevolucao, int idCliente, List<Models.Filme> filmesLocados){
            Models.Locacao locacao = new Models.Locacao(Db.listaLocacaos.Count,dataLocacao,dataDevolucao,idCliente,filmesLocados);
            Db.addLocacao(locacao);
        }

        /// <summary> Validate DateTime format </summary>
        public static DateTime validarData(){
            do{
                Console.WriteLine("Insira a data no seguinte formato => (dd/mm/yyyy)");
                string validaData = Console.ReadLine();
                try{
                    data = Convert.ToDateTime(validaData);
                    validacao = true;
                } catch {
                    Console.WriteLine("O formato da data está incorreto tente novamente");
                    validacao = false;
                }
            }while(validacao == false);
            return data;
        }

        /// <summary> Register a new location </summary>
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
                    filme = Controller.Filme.pesquisarFilme();
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