using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogorpg_orientado_a_objeto
{
    class Monstrons : Personage
    {
        public void classA()
        {
            nivel = 25;
            velocidade = 40;
            vida = 1000;

        }
        public void classB()
        {
            
            nivel = 15;
            velocidade = 30;
            vida = 800;

        }
        public void classC()
        {
            
            nivel = 8;
            velocidade = 20;
            vida = 600;

        }
        public void classD()
        {
            vida = 200;
            nivel = 1;
            velocidade = 10;
            

        }
        public string fraquesaMonstro (string x)
        {
            int valor = int.Parse(x);
            switch (valor)
            {
                case 25:
                    fraquesa = "gelo,machado e fogo";
                    break;
                case 15:
                    fraquesa = "fogo";
                    break;
                case 8:
                    fraquesa = "machado";
                    break;
                case 1:
                    fraquesa = "Tudo";
                    break;
            }
            return fraquesa;



        }

    }
}
