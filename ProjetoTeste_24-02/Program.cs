using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTeste_24_02
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var Motocicleta = new Motocicleta();


            bool continua = true;
            Console.WriteLine("**** SISTEMA DE CONTROLE DE VELOCIDADE ****");            
            Console.WriteLine("Instruções: 1: Acelerar, 2: Frear e 0: Sair");

            while (continua)
            {
                int i = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    Motocicleta.Acelerar();
                }
                else if (i == 2)
                {
                    Motocicleta.Freiar();
                }
                else
                {
                    continua = false;
                }

            }
        }
    }
}
