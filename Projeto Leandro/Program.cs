using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Leandro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Conectar o console com a Control
            Control controle = new Control();//Declaro e instancio a variável

            controle.operacao();//Chamando o método Operação


            Console.ReadLine();//Leia - uso para manter o prompt aberto
        }//Fim do método main
    }//Fim classe program
}//Fim do projeto
