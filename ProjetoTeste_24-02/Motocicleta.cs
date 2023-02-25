using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTeste_24_02
{
    //criei o motocicleta
    public class Motocicleta : Veiculo
    {
        public int Velocidade { get; set; }
        public int Marcha { get; set; }

        public Motocicleta(int velocidade = 0, int marcha = 0)
        {
            Velocidade = velocidade;
            Marcha = marcha;
        }

        public void VerificaMarcha()
        {
            if (Velocidade >= 0 && Velocidade <= 20)
            {
                this.Marcha = 1;
            }
            else if (Velocidade > 20 && Velocidade <= 40)
            {
                this.Marcha = 2;
            }
            else if (Velocidade > 40 && Velocidade <= 60)
            {
                this.Marcha = 3;
            }
            else if (Velocidade > 60 && Velocidade <= 80)
            {
                this.Marcha = 4;
            }
            else if (Velocidade > 80 && Velocidade <= 100)
            {
                this.Marcha = 5;
            }
            else
            {
                this.Marcha = 0;
                this.Velocidade = 0;
            }
        }


        public void ExibirVelocidade()
        {
            if (Velocidade >= 0 && Velocidade <= 100)
                Console.WriteLine($"Marcha.{Marcha} Velocidade.{Velocidade}");
        }

        private bool EstaParado()
        {
            return Velocidade <= 0;
        }

        public override void Acelerar()
        {
            if (EhVelocidadeMaximaVeiculo())
            {
                Velocidade = 100;
                Console.WriteLine("Você já está no máximo");
            }
            else
            {
                Velocidade += 5;
            }

            VerificaMarcha();
            ExibirVelocidade();
        }

        private bool EhVelocidadeMaximaVeiculo()
        {
            return (Velocidade + 5) >= 100;
        }

        public override void Freiar()
        {
            if (EstaParado())
            {
                Velocidade = 0;
                Console.WriteLine("Você já está parado");
            }
            else
            {
                Velocidade -= 8;
            }

            VerificaMarcha();
            ExibirVelocidade();
        }
    }
}
