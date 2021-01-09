using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Atividades
{
	class Program
	{
		public static void Main(string[] args)
		{
			dynamic[] contagem = {
				"um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez",
				"onze", "doze", "treze", "catorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove", "vinte",
				"trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa", "cem",
				"duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos", 
				"mil"
			};

			//relacionamento entre numero Romano com Números
			var numerosRomanos =  new Dictionary<string, int>();


			numerosRomanos.Add("I", 1);
			numerosRomanos.Add("V", 5);
			numerosRomanos.Add("X", 10);
			numerosRomanos.Add("L", 50);
			numerosRomanos.Add("C", 100);
			numerosRomanos.Add("D", 500);
			numerosRomanos.Add("M", 1000);


			string numeroRomano;
			numeroRomano = Console.ReadLine();

			//Inicia conversão de numero string para inteiro
			//int converterNumero = Int32.Parse(numeroRomano);
			//Fim da conversão para número inteiro
			

			//Inicia a lista para ler a sequência dos números romanos
			List<string> elementos = new List<string>();
			
			for (int i = 0; i <= numeroRomano.Length; i++) 
			{
			 	var valorLIdoDaCadeiaDeCaracteres = numeroRomano.Substring(0, 1);
			 	elementos.Add(valorLIdoDaCadeiaDeCaracteres);
			}
			// Console.WriteLine(elementos[0]);

			
			// Meu valor recebe o numero de entrada
			var meuValor = numerosRomanos[numeroRomano];

			var resposta = contagem[meuValor -1];

			Console.WriteLine(resposta);

			// if (meuValor == ) {
			// 	Console.WriteLine("verdadeiro");
			// } else {
			// 	Console.WriteLine("falso");
			// }

		}
	}
}

