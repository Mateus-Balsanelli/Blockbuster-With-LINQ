using DataBase;
using Views;

namespace avaliacaoterceirosemestre
{
    class program
    {
        static void Main(string[] args)
        {
            Db.inserirCadastros();
            MenuInicial.menuPrincipal();
        }

    }
}

