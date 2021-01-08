using System;

namespace Atividades
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("===============================================");
			Console.WriteLine("         Algarismos Romanos por Extenso        ");
			Console.WriteLine("===============================================");

			string numero;

			Console.WriteLine("Por favor, digite um número romano:");
			numero = Console.ReadLine();

			int[] numeros = {1, 5, 10, 50, 100, 500, 1000};
			string[] numerosRomanos = {"I", "V", "X", "L", "C", "D", "M"};
			//encontrar uma forma de relacionar as duas arrays


			// 1- As letras I, X, C, M só podem ser repetidos três vezes consecutivas. Exemplo: III = 3 e XXX = 30; 
			if (numero.Contains("IIII") || numero.Contains("XXXX") || numero.Contains("CCCC") || numero.Contains("MMMM")) {
				Console.WriteLine("Não é um número válido, por favor, tente novamente.");
			} else {Console.WriteLine($"O número digitado foi: {numero}");}

			// 2- No princípio subtrativo, quando duas letras são diferentes e a de menor valor antecede a de maior valor, subtraem-se os seus valores. Exemplo: IV (5 – 1) = 4 e XLV (55 - 10) = 45; 
			// int I = 1;
		 	// int V = 5;
		 	// int X = 10;
		 	// int L = 50;
		 	// int C = 100;
		 	// int D = 500;
		 	// int M = 1000;

			

			string[] armazenamento;
			
			
			for (int i = 0; i < numero.Length; i++) {
				//alimentação do vetor?
				//condicional do menor algarismo vindo antes subtrair 1 porém, não consigo medir isso com a string
				// if() {

				// }
			}
			/* Dificuldades no exercício:

			- leitura de caractere por caractere da palavra e identificação do valor na posição;
			- identificar e calcular os caracteres em cadeia.
			- sintaxe da atribuição do vetor no repetidor for


			*/

			// 3- No princípio aditivo, quando duas letras são diferentes e a de maior valor antecede a de menor valor, somam-se os seus valores. Exemplo: VI (5 + 1) = 6 e LIII (50 + 3) = 53; 

			// 4- Colocando-se um traço sobre uma ou mais letras, seu valor é multiplicado por 1.000;
			
		}
	}
}
