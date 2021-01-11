using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Atividades
{
	class Program
	{
		public static void Main(string[] args)
		{

			string numero = "XIV";
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
				var armazena = numero.Substring(i, 1);
				guardaAlgarismo.Add(armazena);
				soma = soma + numerosRomanos[guardaAlgarismo[i]];
				
			}


			// for (int i = 0; i < guardaAlgarismo.Count -1; i++) {
			// if (i > 0 && numerosRomanos[guardaAlgarismo[i-1]] < numerosRomanos[guardaAlgarismo[i]]) {
					
			// 	}
			// }
			
			// 
			// 	if (numerosRomanos[guardaAlgarismo[i]] < numerosRomanos[guardaAlgarismo[i+1]]) {
			// 		soma = numerosRomanos[guardaAlgarismo[i+1]] - numerosRomanos[guardaAlgarismo[i]];
			// 	} else {
			// 		soma = numerosRomanos[guardaAlgarismo[i]] + numerosRomanos[guardaAlgarismo[i+1]];
			// 	}
			// }

			// if(guardaAlgarismo[0] == "X" || guardaAlgarismo[0] == "X" && numerosRomanos[guardaAlgarismo[1]] > numerosRomanos[guardaAlgarismo[0]]){
			// 	valor = soma + numerosRomanos[guardaAlgarismo[1]]-numerosRomanos[guardaAlgarismo[0]];
			// }
			
			//1º Regra – As letras I, X, C, M somente poderão ser repetidas por três vezes consecutivas.
			if (numero.Contains("IIII") || numero.Contains("XXXX") || numero.Contains("CCCC") || numero.Contains("MMMM") ||
					numero.Contains("VV") || numero.Contains("LL") || numero.Contains("DD")) {
				 Console.WriteLine("Não é um número válido, por favor, tente novamente.");
			} else {Console.WriteLine(soma);}

			
		}
	}
}

