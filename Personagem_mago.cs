using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogorpg_orientado_a_objeto
{
    class Personagem_mago : Personage
    {
        public string runa { get; set; }
        public string magia { get; set; }

        public override int velocidadeAndar()
        {
            return nivel * velocidade + 2;
        }
        

        public void atributos(int nivel)
        {

            if (nivel == 1)
            {
                vida = 100;
                mana = 250;
                int mostrar = danoAtaque();
                Console.WriteLine("------Barra de Vida :{0}", vida);
                Console.WriteLine("------Barra de manda:{0}", mana);
                Console.WriteLine("------velocidade de andar :{0}", velocidadeAndar());
                Console.WriteLine("------Magias:{0}", ataque("1"));
                Console.WriteLine("------Sua Força combina com dano de ataque:{0}", danoAtaque());


            }
        }
        public virtual string ataque(string nivel)
        {
            int nivelAtaque = int.Parse(nivel);
            if (nivelAtaque == 1)
            {
                magia = "utevo lux";
                runa = ", cura";

            }
            return magia + runa ;
        }
        public override int danoAtaque()
        {
            forca = 13;
            habilidade = 20;
            return base.danoAtaque();
        }


    }
}
