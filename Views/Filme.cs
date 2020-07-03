using System;
using DataBase;

namespace Views{

    public class Filme{

        /// <summary> Register a new movie "menu"  </summary>
        public static void cadastrarFilme(){

            Console.WriteLine("Cadastro de filme");
            Console.WriteLine("-----------------");
            Console.WriteLine("Insira o nome do filme");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira a data de lançamento do filme");
            DateTime dataLancamento = Controller.Filme.validarData();
            Console.WriteLine("Escreva uma sinopse para o filme");
            string sinopse = Console.ReadLine();
            Console.WriteLine("Insira um valor para o filme");
            double valor = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero de filmes no estoque");
            int estoque = Int32.Parse(Console.ReadLine());
            Controller.Filme.cadastrarFilme(nome,dataLancamento,sinopse,valor,estoque);

        }
            
    }
}
