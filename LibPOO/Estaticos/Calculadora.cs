using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPOO.Estaticos
{
    /// <summary>
    /// Clase estática contiene operaciones de suma
    /// </summary>
    public static class Calculadora
    {

        //Sobrecarga de métodos
        //Mismo nombre de método diferente cantidad de parámetros

        public static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static int Sumar(int numero1, int numero2, int numero3)
        {
            return numero1 + numero2 + numero3;
        }

        /// <summary>
        /// Realiza una suma de números 
        /// </summary>
        /// <param name="numero1"> Se espera una integer </param>
        /// <param name="numero2"> Se espera una integer </param>
        /// <param name="operador"> Se espera una cadena </param>
        /// <returns> Retorna un decimal total de la suma de numero1 y numero2 </returns>
        public static decimal Sumar(int numero1, int numero2, string operador)
        {
            string valor = operador;
            return numero1 + numero2;
        }

        public static int Sumar(int numero1, int numero2, int numero3, int numero4)
        {
            return numero1 + numero2 + numero3 + numero4;
        }




    }
}
