using System;
using DataBase;
using Controller;
 
namespace Views{
    public class MenuInicial{

        /// <summary> Validation </summary>
        public static void menuPrincipal(){
            do{
                menuMostrarOpcoes();
                int opcao = Controller.MenuInicial.validarNumero();
                menuOpcoeSelecionada(opcao);
            }while(true);
        }
        /// <summary> Main menu </summary>
        public static void menuMostrarOpcoes(){
                Console.WriteLine("########### Bem-Vindo ###########");
                Console.WriteLine("Escolha uma das opções \n");
                Console.WriteLine("[1] Ver Clientes");
                Console.WriteLine("[2] Ver Filmes");
                Console.WriteLine("[3] Ver Locações");
                Console.WriteLine("[4] Cadastrar Cliente");
                Console.WriteLine("[5] Cadastrar Filme");
                Console.WriteLine("[6] Cadastrar Locação");
                Console.WriteLine("[7] Pesquisar Cliente");
                Console.WriteLine("[0] SAIR ");
                Console.WriteLine("-----------------------");
        }
        ///<summary> Main menu options </summary>
        public static void menuOpcoeSelecionada(int opcao){
            switch(opcao){
                case 1:
                    Db.listarCliente();
                break;
                case 2:
                    Db.listarFilme();
                break;
                case 3:
                    Db.listarLocacao();
                break;
                case 4:
                    Cliente.cadastrarCliente();
                break;
                case 5:
                    Filme.cadastrarFilme();
                break;
                case 6:
                    Locacao.cadastrarLocacao();
                break;
                case 7:
                    Controller.Cliente.pesquisarClienteEspecifico();
                break;
                case 8:
                break;
                case 0:
                    Environment.Exit(0);
                break;
            }           
        }
    }
}