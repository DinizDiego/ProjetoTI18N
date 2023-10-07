using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI18N
{
    internal class Control
    {
        Calculadora calc;//Conectando a váriavel calc a classe Calculadora
        private int opcao;
        public Control()
        {
            calc = new Calculadora();//Instanciando, calc é um objeto de calculadora
        }//Fim do Construtor

        public int ConsultarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }//Fim do método

        //Coletar 
        public void ColetarNum1()
        {
            Console.WriteLine("Informe um número: ");
            calc.ConsultarNum1 =Convert.ToDouble(Console.ReadLine());
        }//Fim do método ColetarNum1

        public void ColetarNum2()
        {
            Console.WriteLine("Informe outro número: ");
            calc.ConsultarNum2 = Convert.ToDouble(Console.ReadLine());
        }//Fim do método ColetarNum2

        public void Menu() 
        {
            Console.WriteLine("------ Menu ------" +
                              "\n0.Sair" +
                              "\n1. Somar" +
                              "\n2. Subtrair" +
                              "\n3. Multiplicar" +
                              "\n4. Dividir" +
                              "\n5. Potência" +
                              "\n6. Raiz" +
                              "\n\n Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do método Menu

        //Método que faça a operação
        public void Operacao()
        {
            do
            {
                Menu();
                Console.Clear();//Limpa Tela 
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;

                    case 1:
                        ColetarNum1();//Pegando o primeiro número
                        ColetarNum2();//pegando o segumndo número
                        Console.WriteLine("A soma dos números digitados é: " + calc.Somar());
                        break;

                    case 2:
                        ColetarNum1();//Pegando o primeiro número
                        ColetarNum2();//pegando o segumndo número
                        Console.WriteLine("A subtração dos números digitados é: " + calc.Subtrair());
                        break;

                    case 3:
                        ColetarNum1();//Pegando o primeiro número
                        ColetarNum2();//pegando o segumndo númer 
                        Console.WriteLine("A multiplicação dos números digitados é: " + calc.Multiplicar());
                        break;

                    case 4:
                        ColetarNum1();//Pegando o primeiro número
                        ColetarNum2();//pegando o segumndo número
                        if (calc.Dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir!");
                        }
                        else
                        {
                            Console.WriteLine("A divisão dos números digitados é: " + calc.Dividir());
                        }
                        break;

                    case 5:
                        ColetarNum1();//Pegando o primeiro número
                        ColetarNum2();//pegando o segumndo número
                        Console.Write("A potência é: " + calc.Potencia());
                        break;

                    case 6: 
                        ColetarNum1();
                        Console.WriteLine("A raiz do primeiro número é: " + calc.Raiz());
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida, tente novamente!");
                        break;
                }//Fim do switch
            } while (ConsultarOpcao != 0);
        }//Fim da Operacao
    }//Fim da Classe
}//Fim do Projeto
