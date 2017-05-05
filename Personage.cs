using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogorpg_orientado_a_objeto
{
    class Personage
    {
        public int forca { get; set; }
        public int habilidade { get; set; }
        public int habilidade_especial { get; set; }
        public int velocidade { get; set; }
        public string raça { get;  set; }
        public double altura { get; set; }
        public string sexo { get; set; }
        public int nivel { get; set; }
        public double vida { get; set; }
        public double mana { get; set; }
        public string fraquesa { get; set; }
        public string nome { get; set; }
        public int defesa { get; set; }
        public int ataque { get; set; }

        public virtual void andar()
        {
            Console.WriteLine("Voce esta andando");
        }
        public  virtual int velocidadeAndar()
        {
            return nivel * velocidade;
        }
        public virtual int  danoAtaque()
        {
           
            return forca * habilidade / nivel;
        }

        
        
    }
}
