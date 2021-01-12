using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Atividades
{
	class Program
	{
		public static void Main(string[] args)
		{

			string numero = "CCIX";
			// int valor = 0;
			int soma = 0;

			//Obejetivo: Receber numero romano e transcrever por extenso.

			//2º Regra – As letras I, X, C podem ser escritas na frente das outras, tendo seus valores somados à letra de maior valor.
			// //relacionamento entre numero Romano com Números
			var numerosRomanos =  new Dictionary<string, int>();
			var guardaAlgarismo = new List<string>();

			numerosRomanos.Add("I", 1);
			numerosRomanos.Add("V", 5);
			numerosRomanos.Add("X", 10);
			numerosRomanos.Add("L", 50);
			numerosRomanos.Add("C", 100);
			numerosRomanos.Add("D", 500);
			numerosRomanos.Add("M", 1000);

			// int resultado = 0;
			// int armazenaSoma = 0;


			for (int i = 0; i < numero.Length; i++) {
				// soma = soma + numerosRomanos[numero.Substring(i, 1)];
					var numeroPosterior = 0;
					if (i < numero.Length -1) {
						numeroPosterior = numerosRomanos[numero.Substring(i+1, 1)];
					}
				var numeroAnterior = numerosRomanos[numero.Substring(i, 1)];

				if (numeroAnterior < numeroPosterior) {
					soma -= numerosRomanos[numero.Substring(i, 1)];
				} 
				else 
				{
						soma += numerosRomanos[numero.Substring(i, 1)];
				}
			}
			
			//1º Regra – As letras I, X, C, M somente poderão ser repetidas por três vezes consecutivas.
			if (numero.Contains("IIII") || numero.Contains("XXXX") || numero.Contains("CCCC") || numero.Contains("MMMM") ||
					numero.Contains("VV") || numero.Contains("LL") || numero.Contains("DD")) {
				 Console.WriteLine("Não é um número válido, por favor, tente novamente.");
			} else {Console.WriteLine(soma);}
		}

		// private string RetornaNumeroPorExtenso(int teste, string teste2) {

		// 	var numerosPorExtenso =  new Dictionary<int, string>();

		// 	numerosPorExtenso.Add(1, "Um");
		// 	numerosPorExtenso.Add(2, "Dois");
		// 	numerosPorExtenso.Add(3, "Três");
		// 	numerosPorExtenso.Add(4, "Quatro");
		// 	numerosPorExtenso.Add(5, "Cinco");
		// 	numerosPorExtenso.Add(6, "Seis");
		// 	numerosPorExtenso.Add(7, "Sete");
		// 	numerosPorExtenso.Add(8, "Oito");
		// 	numerosPorExtenso.Add(9, "Nove");
		// 	numerosPorExtenso.Add(10, "Dez");
		// 	numerosPorExtenso.Add(500, "Quinhentos");
		// 	numerosPorExtenso.Add(1000, "Mil");
		// }
	}
}

