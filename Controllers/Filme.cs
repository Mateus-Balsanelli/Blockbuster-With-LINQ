using System;
using DataBase;
using System.Collections.Generic;
using System.Linq;

namespace Controller {

    public class Filme {

        static Boolean validacao = false;

        static DateTime data = DateTime.Now;

        /// <summary> Register a new movie </summary>
        public static void cadastrarFilme(string nome, DateTime dataLancamento, string sinopse, double valor, int estoque){
            Models.Filme filme = new Models.Filme(Db.listaFilmes.Count,nome,dataLancamento,sinopse,valor,estoque);
            Db.addFilme(filme);
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

        ///<summary> show the list of movies  </summary>
        public static Models.Filme pesquisarFilme(){
            int opcaoFilme = 0;
            Models.Filme filme = null;
            do{
                Console.WriteLine("Informe o id do filme");
                opcaoFilme = Int32.Parse(Console.ReadLine());
                try{
                    filme = Db.listaFilmes.Find(filme => filme.idFilme == opcaoFilme);
                    if (filme == null)
                    Console.WriteLine("Filme não localizado");
                }catch{
                    Console.WriteLine("Filme não localizado");
                }

            }while(filme == null);
            return filme;
        }

        ///<summary> Search for a especific movie  </summary>
        public static void pesquisarFilmeEspecifico(){
            System.Console.WriteLine("Menu de Busca filme");
            System.Console.WriteLine("Insira o ID do filme");
            int id = Int32.Parse(Console.ReadLine());
            IEnumerable<Models.Filme> clienteQuery =
                from objeto in Db.Filmes()
                where objeto.idFilme == id
                select objeto;
            foreach(Models.Filme filme in clienteQuery)  {
                System.Console.WriteLine(filme.nomeFilme);
            } 
        }
    }
}