using System;
using DataBase;
 
namespace Views{
    public class MenuInicial{

        public static void menuPrincipal(){
            do{
                int opcao = 100;
                Console.WriteLine("########### Bem-Vindo ###########");
                Console.WriteLine("Escolha uma das opções");
                Console.WriteLine("\n \n");
                Console.WriteLine("[1] Ver Clientes");
                Console.WriteLine("[2] Ver Filmes");
                Console.WriteLine("[3] Ver Locações");
                Console.WriteLine("[4] Cadastrar Cliente");
                Console.WriteLine("[5] Cadastrar Filme");
                Console.WriteLine("[6] Cadastrar Locação");
                Console.WriteLine("[7] SAIR");
                Console.WriteLine("-----------------------");
                try{
                    opcao = Convert.ToInt32(Console.ReadLine());
                } catch {
                    Console.WriteLine("Opção invalida");
                    opcao = 100;
                }
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
                        Environment.Exit(0);
                    break;
                }
            }while(true);
        }
    }
}