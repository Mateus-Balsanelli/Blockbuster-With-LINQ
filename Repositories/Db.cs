using System;
using System.Collections.Generic;
using Models;
using Controller;

namespace DataBase{

    public class Db{

        //////////   Banco de Dados //////////////////////
        
        public static readonly  List<Models.Cliente> listaClientes = new List<Models.Cliente>();
        public static readonly List<Models.Filme> listaFilmes = new List<Models.Filme>();
        public static readonly List<Models.Locacao> listaLocacaos =  new List<Models.Locacao>();

        //////////////////////////Metodos para cadastro ////////////////
    
        public static void addCliente(Models.Cliente cliente){
            listaClientes.Add(cliente);
        }

        public static void addFilme(Models.Filme filme){
            listaFilmes.Add(filme);
        }

        public static void addLocacao(Models.Locacao locacao){
            listaLocacaos.Add(locacao);
        }

        //////////////////metodos para listar todos os items ja cadastrados//////////////
        public static void listarCliente(){
            Console.WriteLine("Lista de Clientes");
            listaClientes.ForEach(cliente => Console.WriteLine(cliente.ToString(true)));
        }

        public static  List<Models.Cliente> Clientes(){
            return listaClientes;
        }
        
        public static void listarFilme(){
            Console.WriteLine("Lista de Filmes");
            listaFilmes.ForEach(filme => Console.WriteLine(filme.ToString(true)));
        }

        public static List<Models.Filme> Filmes(){
            return listaFilmes;
        }

        public static void listarLocacao(){
            System.Console.WriteLine("Lista de locações");
            listaLocacaos.ForEach(locacao => Console.WriteLine(locacao.ToString(true)));
        }

        public static List<Models.Locacao> Locacaos(){
            return listaLocacaos;
        }

        ///<summary> Register customers and movies  </summary>
        public static void inserirCadastros(){
            Controller.Cliente.cadastrarCliente("João Vitor", new DateTime (1990,03,12),"84365725846");
            Controller.Cliente.cadastrarCliente("Dorivaldo da Cunha", new DateTime (1980,11,06),"99835746528");
            Controller.Cliente.cadastrarCliente("Felipe Oliveira", new DateTime (2000,10,05),"77265821148");
            Controller.Cliente.cadastrarCliente("José Pereira", new DateTime (2001,03,03),"75435488722");
            Controller.Cliente.cadastrarCliente("Pedro Pedroso", new DateTime (1970,10,10),"12469852755");

            Controller.Filme.cadastrarFilme("Eu sou uma pedra", new DateTime (2010,11,09),"comedia",3.80,9);
            Controller.Filme.cadastrarFilme("Eu sou uma pedra 2", new DateTime (2011,10,11),"comedia",4.80,7);
            Controller.Filme.cadastrarFilme("Kratos bom de longe", new DateTime (2015,03,02),"ação",5.80,10);
            Controller.Filme.cadastrarFilme("Kratos bom de longe II", new DateTime (2016,07,04),"ação",5.80,9);
            Controller.Filme.cadastrarFilme("kratos bom de longe III", new DateTime (2017,07,07),"ação",6.80,7);
            Controller.Filme.cadastrarFilme("Kratos bom de longe a acensão",new DateTime (2018,08,08),"ação",9.99,8);
            Controller.Filme.cadastrarFilme("Eu não sou seu pai", new DateTime (2014,01,01),"comedia",6.80,9);
            Controller.Filme.cadastrarFilme("Eu + Você", new DateTime (2011,11,03),"Romance",7.80,9);
            Controller.Filme.cadastrarFilme("Um show de Loucuras", new DateTime (2009,10,10),"Aventura",7.80,9);
            Controller.Filme.cadastrarFilme("A vida das baleias", new DateTime(2009,08,06),"Documentário",5.55,3);
            
        }
    }
}