using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace questao_03_04_05
{
    internal class Program
    {

        //3) Observe o trecho de código abaixo: int INDICE = 12, SOMA = 0, K = 1; enquanto K<INDICE faça { K = K + 1; SOMA = SOMA + K; }
        //imprimir(SOMA);
        static void Main(string[] args)
        {
            questao_03();
            Console.ReadKey();
        }

        static void questao_03()
        {

            int INDICE = 12, SOMA = 0, K = 1;

            do
            {
                K += 1;
                SOMA += K;

            } while (K < INDICE);

            Console.WriteLine($"O valor da variável SOMA é igual a {SOMA}");

        }
        //4) Descubra a lógica e complete o próximo elemento:
        //    a) 1, 3, 5, 7, ___ = 9
        //    b) 2, 4, 8, 16, 32, 64, ____ = 128
        //    c) 0, 1, 4, 9, 16, 25, 36, ____ = 49
        //    d) 4, 16, 36, 64, ____ = 100
        //    e) 1, 1, 2, 3, 5, 8, ____ = 13
        //    f) 2, 10, 12, 16, 17, 18, 19, ____ = 200 

        //5) Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em salas diferentes.
        //Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser.
        //Seu objetivo é descobrir qual interruptor controla qual lâmpada.Como você faria para descobrir, usando apenas duas idas
        //até uma das salas das lâmpadas, qual interruptor controla cada lâmpada?
            
        //RESPOSTA: Acendo uma lâmpada aleatória no interuptor por um período considerável. Desligo e imediatamente acendo outra lâmpada e
        //verifico uma das salas. 
        //Se a lâmpada estiver acesa, pertence ao interruptor que acabei de acender. Se a lâmpada estiver apagada e fria, pertence ao
        //interruptor que não usei e se estiver apagada e a lâmpada estiver quente, pertence ao primeiro interruptor. 
        //Com este primeiro interruptor identificado, apago a lâmpada, acendo outro iterruptor e acesso outra sala, fazendo assim a identificação
        //dos outros 2.



    }
}
