using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Leandro
{
    class Calculadora
    {


        //Variáveis Globais
        private double num1;
        private double num2;
        //Método construtor - instancia as variáveis na memória do computador
        public Calculadora()
        {         
        
            Consultarnum1 = 0;
            Consultarnum2 = 0;
        }//Fim do método construtor

        //Métodos modificadores - GET e SET
        public double Consultarnum1
        { 
        
            get { return this.num1; }
            set { this.num1 = value; }       
        
        }//Fim do método consultar num1

        public double Consultarnum2
        {


            get { return this.num2; }
            set { this.num2 = value; }
        }//Fim do método consultar num2


        //Métodos
        public double Somar()
        {

            return Consultarnum1 + Consultarnum2;

        }//Fim do somar

        public double Subtrair()
        {

            return Consultarnum1 - Consultarnum2;
        }//Fim subtrair

        public double Multiplicar()
        {

            return Consultarnum1 * Consultarnum2;
        }//Fim do multiplicar

        public double Dividir()
        {
            if(Consultarnum2 <0) 
            {
                return -1;                    
            }
            else 
            {

                return Consultarnum1 / Consultarnum2;

            }
        }//Fim dividir


    }//Fim da classe
}//Fim do projeto
