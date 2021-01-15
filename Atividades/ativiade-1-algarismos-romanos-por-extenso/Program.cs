using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Atividades
{
	class Program
	{
		public static void Main(string[] args)
		{

			string numero = "";
			numero = Console.ReadLine();

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
			
			// breack se for maior que 5999
			// breack se for maior que 5999
			if (soma < 6000) {
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
				var dezena = 0;

				var escritoPorExtenso = "";
				
				for (int i = somaExtenso.Length-1; i >= 0 ; i--) {
					
					var valorLido = Int32.Parse(somaExtenso.Substring(i, 1));
					
					//UNIDADE
					if (i == somaExtenso.Length-1) {
						
						if (somaExtenso.Length > 1 && valorLido != 0) {
							escritoPorExtenso = " e "+ numeroPorExtenso[somaExtenso.Substring(i, 1)];
						} else {
							escritoPorExtenso = numeroPorExtenso[somaExtenso.Substring(i, 1)];
						}
					}
					//DEZENA
					if (i == somaExtenso.Length-2) {
						dezena = Int32.Parse(somaExtenso.Substring(i, 2));
						if (valorLido == 1) {
							escritoPorExtenso = numeroPorExtenso[somaExtenso.Substring(i, 2)];
						} else if ( valorLido > 1){
							var aux = valorLido * 10;
							
							escritoPorExtenso = numeroPorExtenso[aux.ToString()] + escritoPorExtenso;
						}
						if (dezena >= 10 && somaExtenso.Length > 2 ) {
							escritoPorExtenso = " e " + escritoPorExtenso;
						} 
					}
					
					// Centena
					if (i == somaExtenso.Length-3) {
						var aux = valorLido * 100;
						var centena = Int32.Parse(somaExtenso.Substring(i, 3));
						if (centena > 100 && centena < 200)
						{
							escritoPorExtenso = "cento " + escritoPorExtenso;
						}
						else if ( centena == 100) {
							escritoPorExtenso = numeroPorExtenso[aux.ToString()];
						}
						else
						{
							escritoPorExtenso = numeroPorExtenso[aux.ToString()]+ escritoPorExtenso;
						}
					}

					// Milhares
					if (i == somaExtenso.Length-4) { 
						var milhar = Int32.Parse(somaExtenso.Substring(i, 4));
						dezena = Int32.Parse(somaExtenso.Substring(2, 2));
						var aux = valorLido * 1000;
							if (dezena == 0) {
								escritoPorExtenso = numeroPorExtenso[valorLido.ToString()] +  " mil e " + escritoPorExtenso ;

							} else {
								escritoPorExtenso = numeroPorExtenso[valorLido.ToString()] +  " mil " + escritoPorExtenso ;
							}
					}
					
				}
				Console.WriteLine(escritoPorExtenso); 
			}
			else 
			{
				Console.WriteLine("Erro: Este número está além do nosso limite");
			}
		}
	}
}
