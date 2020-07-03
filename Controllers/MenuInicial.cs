using System;

namespace Controller{

    public static class MenuInicial{
        
        /// <summary> validate the entry of an integer </summary>
        public static int validarNumero() {
            int numero;
            try{
                    numero = Convert.ToInt32(Console.ReadLine());
                } catch {
                    Console.WriteLine("Opção invalida");
                    numero = 100;
                }
            return numero;
        }
    }
}