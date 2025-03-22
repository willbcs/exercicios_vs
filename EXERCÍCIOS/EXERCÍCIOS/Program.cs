using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EXERCÍCIOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EX_01();
            //EX_02();
            //EX_03();
            //EX_04();
            //EX_05();
            EX_06();
            //IMC();
            //Pagamento();
            //Converter();
            //Med_Mai();
            //ArraysP_I();
            Console.ReadKey();
        }

        static void EX_01()
        {
            float[] media = new float[20];
            int aprovados = 0; int contador = 0; float m;
            string Sm;
            while (contador < 20)
            {
                do
                {
                    Console.WriteLine("Digite uma média válida (0 a 10): ");
                    Sm = Console.ReadLine();

                } while (!float.TryParse(Sm, out m) || (m < 0 || m > 10));

                media[contador] = m;

                if (m >= 5)
                {
                    aprovados++;

                }
                contador++;
            }

            for (contador = 0; contador < 20; contador++)
            {

                if (media[contador] >= 5)
                {
                    Console.WriteLine(media[contador]);
                }

            }
            Console.WriteLine(aprovados);

        }

        static void EX_02()
        {
            string Sidade;
            int idade; int contador = 0, adultos = 0;
            int Soma = 0;
            int[] idades = new int[15];

            while (contador < 5)
            {
                do
                {
                    Console.WriteLine("Digite uma idade válida (1 a 120): ");
                    Sidade = Console.ReadLine();

                } while (!int.TryParse(Sidade, out idade) || (idade < 1 || idade > 120));

                idades[contador] = idade;

                if (idade > 18)
                {

                    Soma += idade;
                    adultos++;

                }
                contador++;

            }
            if (adultos == 0)
            {
                Console.WriteLine($"Não há adultos aqui.");
            }
            else
            {
                float media = (float)Soma / adultos;
                Console.WriteLine($"A média de idade dos adultos é {media}");
            }

        }

        static void EX_03()
        {

            float[] numeros = new float[10];
            string Snum;
            float num, maior = 0;
            int cont = 0;

            while (cont < 10)
            {
                do
                {
                    Console.WriteLine("Digite um número positivo!");
                    Snum = Console.ReadLine();

                } while ((!float.TryParse(Snum, out num)) || num < 0);

                numeros[cont] = num;


                if (num - maior > 0)
                {
                    maior = num;
                }
                cont++;
            }

            Console.WriteLine($"O maior número é o: {maior} ");

        }

        static void EX_04()
        {
            int[] ACC = new int[15];
            int[] MCC = new int[15];
            int num, contA = 0, contB = 0, Soma = 0, i = 0;
            string Snum;

            while (i < 15)
            {
                do
                {
                    Console.WriteLine("Digite apenas um número inteiro de 1 a 200: ");
                    Snum = Console.ReadLine();

                } while (!int.TryParse(Snum, out num) || num < 1 || num > 200);

                if (num > 100)
                {
                    ACC[contA] = num;
                    contA++;
                }
                else
                {
                    MCC[contB] = num;
                    contB++;
                }
                Soma += num;
                i++;
            }

            Console.WriteLine("\nOs valores maiores que 100 são: ");
            for (i = 0; i < contA; i++)
            {
                Console.Write($"{ACC[i]}; ");

            }
            Console.WriteLine();

            Console.WriteLine("\nOs valores menores ou iguais a 100 são: ");
            for (i = 0; i < contB; i++)
            {
                Console.Write($"{MCC[i]}; ");
            }
            Console.WriteLine();
            float media = (float)Soma / (contA + contB);
            Console.WriteLine();
            Console.WriteLine($"A média dos valores apresentados é {media}");
        }

        static void EX_05()
        {

            float num1, num2, resultado = 0;
            string operador;

            while (true)
            {
                Console.WriteLine("Digite o primeiro número: ");
                String n1 = Console.ReadLine();

                if (!float.TryParse(n1, out num1))
                {
                    Console.WriteLine("Isso não é um número!");
                }
                else
                {
                    break;
                }

            }
            while (true)
            {
                Console.WriteLine("Digite o primeiro número: ");
                String n2 = Console.ReadLine();

                if (!float.TryParse(n2, out num2))
                {
                    Console.WriteLine("Isso não é um número!");
                }
                else
                {
                    break;
                }

            }

            while (true)
            {
                Console.WriteLine("Escolha entre os operadores '+; -; *; /'");
                operador = Console.ReadLine();
                if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Isso não é um operador válido!");
                }
            }

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;

                case "-":
                    resultado = num1 - num2;
                    break;

                case "*":
                    resultado = num1 * num2;
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;

                    }
                    else
                    {
                        Console.WriteLine("Divisão por 0 não é permitida!");
                        return;
                    }
                    break;

            }
            Console.WriteLine($"O resultado de {num1} {operador} {num2} = {resultado} ");

        }

        static void EX_06()
        {
            int num1;       

            while (true)
            {
                Console.WriteLine("Digite um número positivo: ");
                String n1 = Console.ReadLine();

                if (!int.TryParse(n1, out num1))
                {                       
                    Console.WriteLine("Isso não é um número positivo!");
                }
                else
                {
                    if (num1 < 0) 
                    {
                        Console.WriteLine("Isso não é um número positivo!");

                    }
                    else 
                    {
                        break;
                    }
                }

            }
            Console.WriteLine();
            while (num1 > 0) 
            {
                Console.WriteLine(num1);
                num1 = num1 - 1;
                            
            }
            Console.WriteLine("Fim da contagem!");
        }

        static float Peso(string mensagem)
        {
            while (true)
            {
                Console.WriteLine(mensagem);
                string p = Console.ReadLine();

                if (float.TryParse(p, out float peso))
                {
                    if (peso > 0)
                    {
                        return peso;
                    }
                    else
                    {
                        Console.WriteLine("Não existe peso menor ou igual a 0!");
                    }
                }
                else
                {
                    Console.WriteLine("Caracteres inválidos foram digitados!");
                }
            }
        }

        static float Altura(string mensagem_2)
        {
            while (true)
            {
                Console.WriteLine(mensagem_2);
                string a = Console.ReadLine();

                if (float.TryParse(a, out float altura))
                {
                    if (altura > 0)
                    {
                        return altura;
                    }
                    else
                    {
                        Console.WriteLine("Não existe altura com valor menor ou igual a 0!");
                    }
                }
                else
                {
                    Console.WriteLine("Caracteres inválidos foram digitados!");
                }

            }
        }

        static float Calculadora()
        {
            float massa = Peso("Digite seu peso: ");
            float medida = Altura("Digite sua altura: ");

            return massa / (medida * medida);
        }

        static void IMC()
        {
            float n = Calculadora();
            Console.WriteLine($"Seu IMC é {n:F2}.");
            if (n < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso!");
            }
            else if (n >= 18.5 && n <= 24.9)
            {
                Console.WriteLine("Você está dentro da faixa de peso!");
            }
            else if (n > 24.9 && n < 30)
            {
                Console.WriteLine("Você está obeso em grau I!");
            }
            else if (n >= 30 && n < 40)
            {
                Console.WriteLine("Você está obeso grau II (severa)!");
            }
            else
            {
                Console.WriteLine("Você está obeso grau III (mórbido)!");
            }
        }

        static float Valor(string mensagem)
        {
            while (true)
            {
                Console.WriteLine(mensagem);
                string v = Console.ReadLine();

                try
                {
                    float v_float = float.Parse(v);
                    if (v_float > 0)
                    {
                        return v_float;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("O valor digitado precisa ser maior que zero!");
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Caracteres inválidos foram digitados!");
                }

            }
        }

        static int Menu()
        {
            while (true)
            {
                Console.WriteLine("ESCOLHA A OPÇÃO DE PAGAMENTO DESEJADA:");
                Console.WriteLine("1 - DINHEIRO");
                Console.WriteLine("2 - À VISTA NO CARTÃO");
                Console.WriteLine("3 - PARCELADO NO CARTÃO EM 2X");
                Console.WriteLine("4 - PARCELADO NO CARTÃO EM 3X OU MAIS");
                Console.WriteLine("5 - SAIR");

                Console.WriteLine("Escolha uma opção");
                string pagamento = Console.ReadLine();

                try
                {
                    int o_pagamento = int.Parse(pagamento);
                    if (o_pagamento > 0 && o_pagamento < 5)
                    {
                        return o_pagamento;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Opção inválida!\n");
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Caracteres inválidos foram digitados!\n");
                }
            }
        }

        static void Pagamento()
        {
            while (true)
            {
                float preco = Valor("Digite o valor do produto: ");
                int opcao = Menu();
                Console.Clear();

                if (opcao == 1)
                {
                    float total_1 = preco - (preco * 0.15f);
                    Console.WriteLine($"À vista e em dinheiro, o valor total é de R${total_1} \n\n\n");

                }

                else if (opcao == 2)
                {
                    float total_2 = preco - (preco * 0.1f);
                    Console.WriteLine($"À vista e em dinheiro, o valor total é de R${total_2} \n\n\n");

                }

                else if (opcao == 3)
                {
                    Console.WriteLine($"À vista e em dinheiro, o valor total é de R${preco}\n\n");

                }

                else if (opcao == 4)
                {
                    float total_3 = preco + (preco * 0.1f);
                    Console.WriteLine($"À vista e em dinheiro, o valor total é de R${total_3}\n\n");
                }

                else
                {
                    break;
                }

                Console.WriteLine("Deseja realizar uma nova operação?");
                Console.WriteLine("Digite 's' para sair ou qualquer tecla para continuar:");
                string fim = Console.ReadLine().ToLower();
                if (fim == "s")
                {
                    Console.Clear();
                    Console.WriteLine("Até Logo!!");
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }

        static float temp_Fahrenheit(string mensagem)
        {
            while (true)
            {
                Console.WriteLine(mensagem);
                string far = Console.ReadLine();

                if (float.TryParse(far, out float f_far))
                {
                    return f_far;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Caracteres inválidos foram digitados!\n");
                }

            }


        }

        static void Converter()
        {
            while (true)
            {

                float temp_f = temp_Fahrenheit("Digite a temperatura em Fahrenheit a ser convertida em Celsius:");
                float temp_c = (5 * (temp_f - 32) / 9);
                Console.Clear();

                Console.WriteLine($"A temperatura equivalente em Celsius é {temp_c:F2}°\n");
                Console.WriteLine("Deseja continuar as conversões?");
                Console.WriteLine("Digite 's' para sair ou qualquer tecla para continuar!");
                string end = Console.ReadLine().ToLower();


                if (end == "s")
                {
                    Console.Clear();
                    Console.WriteLine("Até Logo!");
                    break;
                }
                Console.Clear();

            }
        }

        static int Eh_numero(string mensagem)
        {
            while (true)
            {
                Console.WriteLine(mensagem);
                string num1 = Console.ReadLine();

                if (int.TryParse(num1, out int num_1))
                {
                    if (num_1 > 0)
                    {
                        return num_1;
                    }
                    else
                    {
                        Console.WriteLine("Isso não é um número positivo");
                    }
                }
                else
                {
                    Console.WriteLine("Isso não é um número inteiro!");
                }
            }
        }

        static (int menor, int soma, int maior, int[] numeros) Numeros()
        {
            int soma = 0, maior = int.MinValue, menor = int.MaxValue;
            int[] numeros = new int[20];
            for (int i = 0; i < 20; i++)

            {
                int num = Eh_numero("Digite um número inteiro e positivo: ");
                numeros[i] = num;
                soma += numeros[i];


                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }
            return (soma, maior, menor, numeros);

        }

        static void Med_Mai()
        {
            (int soma, int maior, int menor, int[] numeros) = Numeros();
            float media = (soma / 20.0f);
            int cont = 0;
            for (int i = 0; i < 20; i++)
            {
                if (numeros[i] > media)
                {
                    cont++;
                }
            }
            Console.Clear();
            Console.WriteLine($"A soma dos 20 números é {soma}.");
            Console.WriteLine($"O maior número digitado é {maior}.");
            Console.WriteLine($"O menor número digitado é {menor}.");
            Console.WriteLine($"A média dos números é {media:F2}.");
            Console.WriteLine($"A quantidade de números maiores que a média é {cont}.");


        }

        static int Eh_numero2(string mensagem)
        {
            while (true)
            {
                Console.WriteLine(mensagem);
                string num1 = Console.ReadLine();

                if (int.TryParse(num1, out int num_1))
                {
                    if (num_1 != 0)
                    {
                        return num_1;
                    }
                    else
                    {
                        Console.WriteLine("O número não pode ser zero!");
                    }
                }
                else
                {
                    Console.WriteLine("Isso não é um número inteiro!");
                }
            }
        }

        static (int[] numerosI, int[] numerosP) Numeros2()
        {
            List<int> listaP = new List<int>();
            List<int> listaI = new List<int>();
            int[] numeros = new int[20];

            for (int i = 0; i < 20; i++)
            {
                int num = Eh_numero2("Digite um número inteiro: ");
                numeros[i] = num;

                if (num % 2 == 0)
                {
                    listaP.Add(num);
                }
                else
                {
                    listaI.Add(num);
                }
            }

            // Converter listas para arrays com tamanho exato
            int[] numerosP = listaP.ToArray();
            int[] numerosI = listaI.ToArray();

            return (numerosI, numerosP);
        }

        static void ArraysP_I()
        {
            (int[] numerosI, int[] numerosP) = Numeros2();

            Console.WriteLine("Os números pares são:");
            for (int i = 0; i < numerosP.Length; i++)
            {
                Console.WriteLine($"{numerosP[i]}");
            }

            Console.WriteLine("Os números ímpares são:");
            for (int i = 0; i < numerosI.Length; i++)
            {
                Console.WriteLine($"{numerosI[i]}");
            }
        }


        

    }

}
