using System;
using DataBase;

namespace Models{
    public class Filme{

        public int idFilme { get; set; }

        public string nomeFilme { get; set; }

        public  DateTime dataLancamento { get; set; }

        public string sinopse { get; set; }

        public double valor { get; set; }

        public int estoque { get; set; }

        /// <summary>  movie object builder </summary>
        public Filme(int idFilme,string nomeFilme,DateTime dataLancamento,string sinopse,double valor,int estoque){
            this.idFilme = idFilme;
            this.nomeFilme = nomeFilme;
            this.dataLancamento = dataLancamento;
            this.sinopse = sinopse;
            this.valor = valor;
            this.estoque = estoque;
        }

        /// <summary>  Movie object toString </summary>
        public string ToString(Boolean aux = false){
            string retorno = $"Id :{idFilme} # Nome:{nomeFilme} # Data de Lançamento:{dataLancamento} # Valor:{valor} # Estoque:{estoque} # Sinopse:{sinopse}"; 
            return retorno;
        }

    }
}
