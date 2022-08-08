using System;

namespace FlexLogicalTest
{
    internal class Program
    {
        /*
        * Um número primo é aquele que é divisível apenas por um e por ele mesmo. 
        * Obs: O número 1 não é primo.
        * Escreva uma função otimizada que, dado um número inteiro positivo, retorne true se o
        * número for primo ou false caso contrário, com o menor número de iterações possível.
        * Imprima o resultado em tela da seguinte forma: 
        * “O número num é primo. Número de iterações necessárias: count”
        * ou
        * “O número num não é primo. Número de iterações necessárias: count”
        */

        static void Main(string[] args)
        {
            int iteracao;

            Console.WriteLine("Digite um número (0 para sair):");
            int numero = Convert.ToInt32(Console.ReadLine().Trim());

            while (numero > 0)
            {
                bool resultado = EhNumeroPrimo(numero, out iteracao);

                ImprimirResultado(numero, resultado, iteracao);

                Console.WriteLine("Digite um número (0 para sair):");
                numero = Convert.ToInt32(Console.ReadLine().Trim());
            }

        }

        private static bool EhNumeroPrimo(int numero, out int contador)
        {
            contador = 0;

            if (numero < 2)
                return false;
            if (numero % 2 == 0)
                return numero == 2;

            int raiz = (int)Math.Sqrt(numero);

            for (int iteracao = 3; iteracao <= raiz; iteracao += 2)
            {
                contador++;
                if (numero % iteracao == 0) return false;
            }

            return true;
        }

        private static void ImprimirResultado(int numero, bool resultado, int contador)
        {
            Console.WriteLine($"O número {numero} {(resultado ? "é primo" : "não é primo")}. Número de iterações necessárias: {contador}");
        }
    }
}
