using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogorpg_orientado_a_objeto
{
    class Personagem_kina : Personage
    {
        public int pesoArmadura { get; set; }
        public double resistencia { get; set; }
      


        public override int danoAtaque()
        {
            forca = ataque + 20;
            habilidade = 30;
            nivel = 1;
            return base.danoAtaque();
        }

        public override int velocidadeAndar()
        {
            nivel = 1;
            velocidade = 1;
            return base.velocidadeAndar();
        }
        
        public void arma(int tipoArma )
        {
            if (tipoArma == 1)
            {
                ataque = 15;
                defesa = 10;
               
                Console.WriteLine("Voce escolheu machado");

            }
            else if (tipoArma == 2)
            {
                defesa = 5;
                ataque = 15;
                Console.WriteLine("Voce escolheu espada");

            }
            else 
            {
              Console.WriteLine("Arma não existe");
            }
         

        }

    }
}
