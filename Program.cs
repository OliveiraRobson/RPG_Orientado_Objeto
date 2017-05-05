using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jogorpg_orientado_a_objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoje eu vim até voce para pedir a sua ajuda,estamos em busca de novos guerreiros para que possa lutar na batalha mais feroz que ja existiu","\n");
            Console.WriteLine("Voce é a nossa unica saida ,peço para que comece essa nova jorna rumo as montanhas perdidas","\n");
            int valor;
            string personagem;
            Personage robson = new Personage();
            Console.WriteLine("Escolha seu personagem  >>>>> Mago = 2 , Kina = 3 <<<<<<<<");
            personagem = Console.ReadLine();
            valor = int.Parse(personagem);
       
            if (valor == 2)
            { 
                Personagem_mago mago = new Personagem_mago();
                Console.WriteLine("Digite seu sexo M = Masculino ou F = Femenino");
                mago.sexo = Console.ReadLine();
                Console.WriteLine("Digite o nome do seu personagem");
                mago.nome = Console.ReadLine();
                if (mago.sexo == "m")
                {
               
                    mago.nivel = 1;
                    mago.velocidade = 2;
                    Console.WriteLine("Seja bem vindo mago {0} ,vamos juntos se aventura nessa historia emocionante", mago.nome);
                    Console.WriteLine("\n");
                    Console.WriteLine("----------------------------------------------------------------------------");
                    mago.atributos(1);
                    

                }
                else
                {
                    Console.WriteLine("Seja bem vindo maga {0} ,vamos juntos se aventura nessa historia emocionante", mago.nome);
                    Console.WriteLine("\n");
                    Console.WriteLine("--------------------------------------------------------------------------");
                    mago.atributos(1);
                }
            }
            if(valor == 3)
            {
                Personage kina = new Personage();
                Console.WriteLine("Digite seu sexo M = Masculino ou F = Femenino");
                kina.sexo = Console.ReadLine();
                Console.WriteLine("Digite nome do seu personagem");
                kina.nome = Console.ReadLine();
                if (kina.sexo == "m")
                {
                    Console.WriteLine("Seja bem vindo kina {0} ,vamos juntos se aventura nessa historia emocionante", kina.nome);
                    Console.WriteLine("\n");
                    Console.WriteLine("----------------------------------------------------------------------------");

                }

            }

        }
    }
}
