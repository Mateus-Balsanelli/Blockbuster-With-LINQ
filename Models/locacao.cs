using System;
using System.Collections.Generic;
using DataBase;


namespace Models {
    public class Locacao {

        public int idLocacao { get; set; }

        public DateTime dataLocacao { get; set;}

        public DateTime dataDevolucao { get; set; }

        public int idCliente { get; set; }

        public List<Filme> filmesLocados { get; set; }


        /// <summary>  location object builder </summary>
        public Locacao(int idLocacao, DateTime dataLocacao, DateTime dataDevolucao, int idCliente, List<Filme> filmesLocados ){
            this.idLocacao = idLocacao;
            this.dataLocacao = dataLocacao;
            this.dataDevolucao = dataDevolucao;
            this.idCliente = idCliente;
            this.filmesLocados = filmesLocados;
            Db.addLocacao(this);

        }

        /// <summary>  location object toString </summary>
        public string ToString(Boolean aux =false){
            string retorno = $"Id :{idLocacao} # Data Locação:{dataLocacao} # Data de Devolução:{dataDevolucao} # ID do cliente:{idCliente} # Filmes locados:{filmesLocados}";
            return retorno; 
        }    
    }
}