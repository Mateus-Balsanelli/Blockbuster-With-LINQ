using System;
using DataBase;

namespace Controller {

    public class Filme {

        static Boolean validacao = false;

        static DateTime data = DateTime.Now;

        public static void cadastrarFilme(string nome, DateTime dataLancamento, string sinopse, double valor, int estoque){
            Models.Filme filme = new Models.Filme(Db.listaFilmes.Count,nome,dataLancamento,sinopse,valor,estoque);
            Db.addFilme(filme);
        }

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
    }
}