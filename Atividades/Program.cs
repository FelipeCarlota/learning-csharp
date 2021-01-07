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

			//Testando a Condicional if
			if (numero == "I") {
				numero = "Um";
			}

			Console.WriteLine($"O número digitado foi: {numero}");
		}
	}

	

}
