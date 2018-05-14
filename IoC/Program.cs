using IoC.ConstructorMethodology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    class Program
    {
        static void Main(string[] args)
        {
            EnderecoPlus enderecoPlus = new EnderecoPlus();
            Empresa empresa = new Empresa(enderecoPlus);

            Endereco endereco = new Endereco();
            Empresa empresa2 = new Empresa(endereco);
        }
    }
}
