using System;
using System.Collections.Generic;
using System.Linq;
using DataBase;
using Models;

namespace Views{

    public class Filme{

        public static void cadastrarFilme(){

            Console.WriteLine("Cadastro de filme");
            Console.WriteLine("-----------------");
            Console.WriteLine("Insira o nome do filme");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira a data de lançamento do filme");
            DateTime dataLancamento = Controllers.Filme.validarData();
            Console.WriteLine("Escreva uma sinopse para o filme");
            string sinopse = Console.ReadLine();
            Console.WriteLine("Insira um valor para o filme");
            double valor = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero de filmes no estoque");
            int estoque = Int32.Parse(Console.ReadLine());
            Models.Filme.cadastrarFilme(nome,dataLancamento,sinopse,valor,estoque);

        }
        public static void pesquisarFilme(){
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
