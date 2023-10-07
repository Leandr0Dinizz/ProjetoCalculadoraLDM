using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Projeto_Leandro
{
    internal class Control
    {

        Calculadora calc;//Conectando a variável calc a classe calculadora 
        private int opcao;
        public Control()
        {
            calc = new Calculadora();//Instanciando, calc é um objeto de calculadora
        }//Fim do construtor

        public int ConsultarOpcao
        {

            get { return opcao; }   
            set { opcao = value; }
        }//Fim do método


        //Método coletar
        public void ColetarNum1()
        {

        Console.WriteLine("Informe um número: ");
        calc.Consultarnum1 = Convert.ToDouble(Console.ReadLine());    
        }//Fim do método coletarNum1

        public void ColetarNum2()
        {

            Console.WriteLine("Informe outro número: ");
            calc.Consultarnum2 = Convert.ToDouble(Console.ReadLine());
        }//Fim do método coletarNum2

        public void Menu()
        {

            Console.WriteLine(" --------Menu-------- " +
                              "\n0. Sair" +
                              "\n1.  Somar" +
                              "\n2.  Subtrair" +
                              "\n3.  Divisão" +
                              "\n4.  Multiplicar"+
                              "\n\n.  Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());       
        }//Fim método menu


        //Método que faz a operação
        public void operacao()
        {
            do// FAÇA ENQUANTO - REPITA ATÉ
            {
                
                
                Menu();
                Console.Clear();//Limpa tela
                switch (ConsultarOpcao)//Escolha - CASO -
                {

                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;//Encerrar o processo

                    case 1:
                        ColetarNum1();//Pegando o primeiro número
                        ColetarNum2();//Pegando o segundo número
                        Console.WriteLine("A soma dos número digitados é: " + calc.Somar());
                        break;
                    case 2:
                        ColetarNum1();
                        ColetarNum2();
                        Console.WriteLine("A subtração dos números digitados é: " + calc.Subtrair());
                        break;
                    case 3:
                        ColetarNum1();
                        ColetarNum2();
                        if (calc.Dividir() == -1)
                        {

                            Console.WriteLine("Impossível dividir!");
                        }
                        else
                        {
                            Console.WriteLine("A divisão dos números digitados é: " + calc.Dividir());
                        }
                        break;

                    case 4:
                        ColetarNum1();
                        ColetarNum2();
                        Console.WriteLine("A multiplicação dos números digitados é: " + calc.Multiplicar());
                        break;

                    default:
                        Console.WriteLine("Opção escolhida não é válida, Tente novamente!");
                        break;
                }//Fim switch
            } while (ConsultarOpcao != 0);//REPITA ATÉ - FAÇA ENQUANTO
        }//Fim operação


    }//Fim da classe
}//Fim projeto
