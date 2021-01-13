using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Atividades
{
	class Program
	{
		public static void Main(string[] args)
		{

			string numero = "MCX";

			// int valor = 0;
			int soma = 0;

			//Obejetivo: Receber numero romano e transcrever por extenso.

			//2º Regra – As letras I, X, C podem ser escritas na frente das outras, tendo seus valores somados à letra de maior valor.
			// //relacionamento entre numero Romano com Números
			var numerosRomanos =  new Dictionary<string, int>() {
				{"I", 1},
			  {"V", 5},
			  {"X", 10},
			  {"L", 50},
			  {"C", 100},
			  {"D", 500},
			  {"M", 1000}};
			var guardaAlgarismo = new List<string>();

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
			if (numero.Contains("IIII") || numero.Contains("XXXX") || numero.Contains("CCCC") || 
					numero.Contains("VV") || numero.Contains("LL") || numero.Contains("DD")) {
				 Console.WriteLine("Este número não é válido, entretanto, para os casos de numeros maiores do que mil, utilize a letra M. Lembrando que ele é representado pelo algarismo unitário e um risco em cima.s"); 
			} 
			
			// breack se for maior que 5999
			if (soma >= 6000) 
			{
				Console.WriteLine("Erro: Este número está além do nosso limite");
			}



			// Escreve por extenso
			var numeroPorExtenso = new Dictionary<string, string> {{"0", ""},{"1", "um"}, {"2", "dois"}, {"3", "três"}, {"4", "quatro"}, {"5", "cinco"},
																													{"6", "seis"}, {"7", "sete"}, {"8", "oito"}, {"9", "nove"}, {"10", "dez"},
																													{"11", "onze"}, {"12", "doze"}, {"13", "treze"}, {"14", "catorze"}, {"15", "quinze"},
																													{"16", "dezsseis"}, {"17", "dezessete"}, {"18", "dezoito"}, {"19", "dezenove"}, {"20", "vinte"},
																													{"30", "trinta"}, {"40", "quarenta"}, {"50", "cinquenta"}, {"60", "sessenta"}, {"70", "setenta"},
																													{"80", "oitenta"}, {"90", "noventa"}, {"100", "cem"}, {"200", "duzentos"}, {"300", "trezentos"},
																													{"400", "quatrocentos"}, {"500", "quinhentos"}, {"600", "seicentos"}, {"700", "setessentos"}, 
																													{"800", "oitocentos"}, {"900", "Quinhentos"}, {"1000", "mil"}};


		var somaExtenso = soma.ToString();

			var escritoPorExtenso = "";
			
			for (int i = somaExtenso.Length-1; i >= 0 ; i--) {
				var valorLido = Int32.Parse(somaExtenso.Substring(i, 1));
				
				//UNIDADE
				if (i == somaExtenso.Length-1) {
					escritoPorExtenso = numeroPorExtenso[somaExtenso.Substring(i, 1)];
				}
				//DEZENA
				if (i == somaExtenso.Length-2) {
					
				  if (valorLido == 1) {
						escritoPorExtenso = numeroPorExtenso[somaExtenso.Substring(i, 2)];
					} else if ( valorLido > 1){
						var aux = valorLido * 10;
						if (aux == 50) 
						{
							escritoPorExtenso = numeroPorExtenso[aux.ToString()] + escritoPorExtenso;
						}
						else 
						{
							escritoPorExtenso = numeroPorExtenso[aux.ToString()] + " e " +  escritoPorExtenso;
						}
						
					}
				}

				// Centena
				if (i == somaExtenso.Length-3) {
					var aux = valorLido * 100;
					if (aux == 100 && somaExtenso.Length -1 -1 != 0 && somaExtenso.Length -1 -2 != 0)
					{
						escritoPorExtenso = "cento" + " e " + escritoPorExtenso;
					}
					else if ( aux == 100) {
						escritoPorExtenso = numeroPorExtenso[aux.ToString()];
					}
					else if (somaExtenso.Length-3 - 1 == 0) 
					{
						escritoPorExtenso = numeroPorExtenso[aux.ToString()];
					}
					else
					{
						escritoPorExtenso = numeroPorExtenso[aux.ToString()] + " e " + escritoPorExtenso;
					}
				}

				// Milhares
				if (i == somaExtenso.Length-4) { // Tratar o 0 da dezena, centena
					var aux = valorLido * 1000;

					if (aux == 1000 && somaExtenso.Length -1 -1 == 0) 
					{
						escritoPorExtenso = " mil " + escritoPorExtenso;
					}
					if (aux > 1000)
					{
					//	escritoPorExtenso = numeroPorExtenso[valorLido.ToString()] +  " mil " + escritoPorExtenso + " e " + escritoPorExtenso;
					}
					else
					{
						// Console.WriteLine(valorLido);
						//escritoPorExtenso = numeroPorExtenso[somaExtenso.Substring(i, 1)] + "" + numeroPorExtenso[aux.ToString()] + " e " + escritoPorExtenso;
					}
				}
				
			}
			Console.WriteLine(escritoPorExtenso); 
		}
	}
}

