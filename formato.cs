using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogorpg_orientado_a_objeto
{
    class formato
    {
        public string conteudo { get; set; }
        public void formatoTela()
        {
            
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("-", "--------------------------------------------------");
            Console.WriteLine("-{0)}",conteudo);
            Console.WriteLine("-");
            Console.WriteLine("-");
            Console.WriteLine("-");
            Console.WriteLine("-");
            Console.WriteLine("-");
            Console.WriteLine("-");
            Console.WriteLine("-");
            Console.WriteLine("-");
            Console.WriteLine("----------------------------------------------------------------------------");
        }
    }
}
