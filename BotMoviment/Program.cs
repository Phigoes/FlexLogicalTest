using System;
using System.Collections.Generic;
using System.Linq;

namespace BotMoviment
{
    internal class Program
    {
        /*
         * Existe um bot localizado em um par de coordenadas inteiras, (x, y). Ele pode ser movido para
         * um outro par de coordenadas. Embora o bot possa se mover quantas vezes quiser, ele só pode
         * fazer os dois tipos de movimentos a seguir:
         * 
         *  1. Da posição (x, y) para a posição (x + y, y).
         *  2. Da posição (x, y) para a posição (x, x + y).
         * 
         * Por exemplo, se o bot começa em (1, 1), ele pode fazer a seguinte sequência de movimentos:
         * (1, 1) → (1, 2) → (3, 2) → (5, 2).
         * 
         * Escreva uma função que, dadas as coordenadas iniciais e finais, determine se o bot pode
         * alcançar as coordenadas finais de acordo com as regras de movimento.
         * 
         * Descrição da função:
         * A função deve retornar true se o bot puder atingir seu objetivo, caso contrário, retorne false.
         * A função tem o(s) seguinte(s) parâmetro(s):
         * 
         *  x1: valor inteiro, coordenada x inicial
         *  y1: valor inteiro, coordenada y inicial
         *  x2: valor inteiro, coordenada x final
         *  y2: valor inteiro, coordenada y final
         */

        static void Main(string[] args)
        {
            List<int> inicio = new List<int>();
            List<int> deslocamento = new List<int>();
            int x1, y1, x2, y2;

            do
            {
                Console.WriteLine("Digite a posição inicial (x,y):");
                inicio = Console.ReadLine().TrimEnd().Split(',').ToList().Select(array => Convert.ToInt32(array)).ToList();
            }
            while (inicio.Count != 2);

            x1 = inicio.First();
            y1 = inicio.Last();
            
            while (true)
            {
                do
                {
                    Console.WriteLine("Digite a posição de deslocamento (x,y):");
                    deslocamento = Console.ReadLine().TrimEnd().Split(',').ToList().Select(array => Convert.ToInt32(array)).ToList();
                }
                while (deslocamento.Count != 2);

                x2 = deslocamento.First();
                y2 = deslocamento.Last();

                var resultado = Deslocamento(x1, y1, x2, y2);

                if (resultado)
                {
                    x1 = x2;
                    y1 = y2;
                    ImprimirResultado(resultado);
                }
                else
                    ImprimirResultado(resultado);
            }
        }

        public static bool Deslocamento(int x1, int y1, int x2, int y2)
        {
            if (x2 == x1 + y1 && y1 == y2)
                return true;
            else if (y2 == x1 + y1 && x1 == x2)
                return true;

            return false;
        }

        public static void ImprimirResultado(bool resultado)
        {
            if (resultado)
                Console.WriteLine("Movimento autorizado.");
            else
                Console.WriteLine("Movimento não autorizado");
        }
    }
}
