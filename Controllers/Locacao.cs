using System;
using System.Collections.Generic;
using DataBase;
using Models;

namespace Controller{

    public class Locacao {

        static Boolean validacao = false;

        static DateTime data = DateTime.Now;

        public static void cadastrarLocacao(DateTime dataLocacao, DateTime dataDevolucao, int idCliente, List<Models.Filme> filmesLocados){
            Models.Locacao locacao = new Models.Locacao(Db.listaLocacaos.Count,dataLocacao,dataDevolucao,idCliente,filmesLocados);
            Db.addLocacao(locacao);
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

        
    }
}