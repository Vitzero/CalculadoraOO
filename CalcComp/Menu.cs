using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Calculadora;

namespace Calculadora;

static class Menu
{
     

    public static void ExibirMenu() // exibe o logo e ja chama o switch pra realizar as operações do usuario
    {
        Console.WriteLine("\n|===========|");
        Console.WriteLine("|Calculadora|");
        Console.WriteLine("|===========|");
        RealizarOperacoes();
        Console.ReadKey();
        
    }

    public static void RealizarOperacoes()
    { 
        int numerosEntrada;

        while (true) // laço de repetição para tratar possiveis erros de entrada
        {
            
            try // tenta rodar o codigo sem erros
            {
                //instrução e select do switch
                Console.WriteLine("\ndigite:\n[1] Soma\n[2] Subtrair\n[3] divisão\n[4] Multiplicar\n[5] exponenciação\n[6] porcentagem\n[-1] Sair ");
                Console.WriteLine("|===========");
                int opt;
                opt = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                if (opt == -1) // saida do loop
                {
                    Console.WriteLine("saindo..");
                    break;
                }
                else if (opt > 6 || opt == 0 || opt < -1)
                {
                    Console.WriteLine("digite uma das opções!");
                    continue;
                }
                else if (opt == 6) {
                    Console.WriteLine("Digite 2 numeros: ");
                    double n1 = double.Parse(Console.ReadLine());
                    double n2 = double.Parse(Console.ReadLine());

                    Porcentagem percent = new Porcentagem(n1, n2);

                    double resultado = percent.Porcentar();

                    Console.WriteLine($"O resultado da porcentagem {n1} de {n2} é: {resultado:F2}%");
                    Console.ReadKey();

                    Console.WriteLine("Operação concluida com sucesso!");
                    continue;

                }

                

                while (true)
                {
                    try
                    {
                        
                        Console.WriteLine("\ndigite quantos numeros quer:");
                        numerosEntrada = int.Parse(Console.ReadLine());

                        double[] doubles = new double[numerosEntrada];

                        for (int i = 0; i < doubles.Length; i++)
                        {
                            Console.WriteLine($"digite o valor do número {i + 1}:");
                            doubles[i] = Double.Parse(Console.ReadLine());
                        }



                        switch (opt) // operações, cada case instancia a classe que contém o método da operação, dando return no resultado
                        {

                            case 1:


                                double resultado = 0;
                                Soma somar = new Soma(); 
                                resultado = somar.CalcularSoma(doubles);


                                Console.WriteLine($"A soma dos números é: {resultado:F2}");
                                Console.ReadKey();
                                break;

                            case 2:

                                Subtrair sub = new Subtrair();

                                resultado = sub.CalcularSubtrair(doubles);
                                Console.WriteLine($"O resultado da subtração é: {resultado:F2}");
                                Console.ReadKey();
                                break;

                            case 3:

                                Dividir divisor = new Dividir();

                                resultado = divisor.CalcularDivisao(doubles);

                                Console.WriteLine($"O resultado da divisão é: {resultado:F2}");
                                Console.ReadKey();

                                break;
                            case 4:

                                Multiplicacao multiplicar = new Multiplicacao();

                                resultado = multiplicar.Multiplicar(doubles);
                                
                                Console.WriteLine($"O resultado da multiplicação é: {resultado:F2}");
                                Console.ReadKey();
                                break;

                            case 5:

                                Exponenciar potencia = new Exponenciar();

                                resultado = potencia.Exponenciando(doubles);
                                
                                Console.WriteLine($"O resultado da exponenciação é: {resultado:F2}");
                                Console.ReadKey();
                                break;

                            default:
                                Console.WriteLine("Opção Inválida!");
                                break;
                        }


                        break;

                    }
                    catch (Exception ex) {
                        Console.WriteLine("--------------------\ndigite numeros validos!!\n--------------------");
                    }

                }

               

                
            }
            catch(FormatException) { //tratamento de erro para formato inválido
                
                Console.WriteLine("------------------");
                Console.WriteLine("Só coloque números!");
                Console.WriteLine("------------------");

            }
            catch(OverflowException) // tratamento pra sobrecarga de números
            {

                Console.WriteLine("------------------");
                Console.WriteLine("Número grande ou pequeno demais!");
                Console.WriteLine("------------------");

            }
            catch (Exception) // pega erros no geral
            {
                
                Console.WriteLine("----------------------");
                Console.WriteLine("Digite um valor válido!");
                Console.WriteLine("----------------------");
            }


            Console.WriteLine("\nOperação concluida com sucesso!\n");
        }
    }
}
