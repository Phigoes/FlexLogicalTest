using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Palindrome
{
    internal class Program
    {
        /*
        * Palíndromo, do grego palin (novo) e dromo (percurso), é toda palavra ou frase que quando lida
        * ao contrário, desconsiderando espaços e pontuações, possui o mesmo sentido. Ex.: “asa”,
        * “ovo”, “A base do teto desaba”. 
        * 
        * Escreva uma função que receba uma string como parâmetro e retorne true caso o valor dessa
        * string seja um palíndromo ou false, caso contrário.
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Digite a palavra ou a frase (0 para sair):");
            string texto = Console.ReadLine();

            while(true)
            {
                if (texto.Length == 1 && texto[0] == '0')
                    return;

                if (EhPalindromo(texto))
                    Console.WriteLine($"O texto é um palíndromo");
                else
                    Console.WriteLine($"O texto não é um palíndromo");

                Console.WriteLine("Digite a palavra ou a frase (0 para sair):");
                texto = Console.ReadLine();
            }
        }

        public static bool EhPalindromo(string texto)
        {
            string textoComRegex = new Regex("[^a-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ]").Replace(texto, "").ToLower();
            string resultado = RemoverAcentos(textoComRegex);

            return !resultado.Where((caracter, index) => caracter != resultado[resultado.Length - index - 1]).Any();
        }

        public static string RemoverAcentos(string texto)
        {
            StringBuilder resultado = new StringBuilder();
            var arrayDoTexto = texto.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letra in arrayDoTexto)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letra) != UnicodeCategory.NonSpacingMark)
                    resultado.Append(letra);
            }

            return resultado.ToString();
        }
    }
}
