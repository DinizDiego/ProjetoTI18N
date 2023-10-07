using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI18N
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conectar o console com a Control
            Control controle= new Control();//Declaro e instancio a variável
            controle.Operacao();//Método Operação

            Console.ReadLine();//Leia - Uso para manter o prompt aberto
        }//Fim do método main
    }//Fim da calsse Program
}//Fim do projeto
