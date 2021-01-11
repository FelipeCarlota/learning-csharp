// dynamic[] contagem = {
// 				"um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez",
// 				"onze", "doze", "treze", "catorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove", "vinte",
// 				"trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa", "cem",
// 				"duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos", 
// 				"mil"
// 			};

// 			//relacionamento entre numero Romano com Números
// 			var numerosRomanos =  new Dictionary<string, int>();

// 			/* Dictionary
// 			Propriedades:

// 			Count						Obtém o número total de elementos no Dictionary<TKey,TValue>.
//  			IsReadOnly			Retorna um booleano indicando se o Dictionary<TKey,TValue> é somente leitura.
//  			Item						Obtém ou define o elemento com a chave especificada no Dictionary<TKey,TValue>.
//  			Keys						Retorna a coleção de chaves do Dictionary<TKey,TValue>
//  			Values					Retorna a coleta de valores no Dictionary<TKey,TValue>.


// 			Métodos:

// 			Add							Adiciona um item à coleção Dictionary.
// 			Add							Adiciona pares de valores-chave na coleção Dictionary<TKey,TValue>.
// 			Remove					Remove a primeira ocorrência do item especificado do Dictionary<TKey,TValue>.
// 			Remove					Remove o elemento com a chave especificada.
// 			ContainsKey			Verifica se a chave especificada existe em Dictionary<TKey,TValue>.
// 			ContainsValue		Verifica se o valor especificado existe em Dictionary<TKey,TValue>.
// 			Clear						Remove todos os elementos do Dictionary<TKey,TValue>.
// 			TryGetValue			Retorna true e atribui o valor com a chave especificada, se a chave não existir, retorna false.
// 			*/

// 			numerosRomanos.Add("I", 1);
// 			numerosRomanos.Add("II", 2);
// 			numerosRomanos.Add("III", 3);
// 			numerosRomanos.Add("IV", 4);
// 			numerosRomanos.Add("V", 5);
// 			numerosRomanos.Add("VI", 6);
// 			numerosRomanos.Add("VII", 7);
// 			numerosRomanos.Add("VIII", 8);
// 			numerosRomanos.Add("IX", 9);
// 			numerosRomanos.Add("X", 10);
// 			numerosRomanos.Add("XI", 11);
// 			numerosRomanos.Add("XII", 12);
// 			numerosRomanos.Add("XIII", 13);
// 			numerosRomanos.Add("XIV", 14);
// 			numerosRomanos.Add("XV", 14);
// 			numerosRomanos.Add("XVI", 16);
// 			numerosRomanos.Add("XVII", 17);
// 			numerosRomanos.Add("XVIII", 18);
// 			numerosRomanos.Add("XIX", 19);
// 			numerosRomanos.Add("XX", 20);
// 			numerosRomanos.Add("XXI", 21);
// 			numerosRomanos.Add("XXII", 22);
// 			numerosRomanos.Add("XXIII", 23);
// 			numerosRomanos.Add("XXIV", 24);
// 			numerosRomanos.Add("XXV", 25);
// 			numerosRomanos.Add("XXVI", 26);
// 			numerosRomanos.Add("XXVII", 27);
// 			numerosRomanos.Add("XXVIII", 28);
// 			numerosRomanos.Add("XXIX", 29);
// 			numerosRomanos.Add("XXX", 30);
// 			numerosRomanos.Add("XXXI", 31);
// 			numerosRomanos.Add("XXXII", 32);
// 			numerosRomanos.Add("XXXIII", 33);
// 			numerosRomanos.Add("XXXIV", 34);
// 			numerosRomanos.Add("XXXV", 35);
// 			numerosRomanos.Add("XXXVI", 36);
// 			numerosRomanos.Add("XXXVII", 37);
// 			numerosRomanos.Add("XXXVIII", 38);
// 			numerosRomanos.Add("XXXIX", 39);
// 			numerosRomanos.Add("XL", 40);
// 			numerosRomanos.Add("XLI", 41);
// 			numerosRomanos.Add("XLII", 42);
// 			numerosRomanos.Add("XLIII", 43);
// 			numerosRomanos.Add("XLIV", 44);
// 			numerosRomanos.Add("XLV", 45);
// 			numerosRomanos.Add("XLVI", 46);
// 			numerosRomanos.Add("XLVII", 47);
// 			numerosRomanos.Add("XLVIII", 48);
// 			numerosRomanos.Add("XLIX", 49);
// 			numerosRomanos.Add("L", 50);
// 			numerosRomanos.Add("LI", 51);
// 			numerosRomanos.Add("LII", 52);
// 			numerosRomanos.Add("LIII", 53);
// 			numerosRomanos.Add("LIV", 54);
// 			numerosRomanos.Add("LV", 55);
// 			numerosRomanos.Add("LVI", 56);
// 			numerosRomanos.Add("LVII", 57);
// 			numerosRomanos.Add("LVIII", 58);
// 			numerosRomanos.Add("LIX", 59);
// 			numerosRomanos.Add("LX", 60);
// 			numerosRomanos.Add("LXI", 61);
// 			numerosRomanos.Add("LXII", 62);
// 			numerosRomanos.Add("LXIII", 63);
// 			numerosRomanos.Add("LXIV", 64);
// 			numerosRomanos.Add("LXV", 65);
// 			numerosRomanos.Add("LXVI", 660);
// 			numerosRomanos.Add("LXVII", 67);
// 			numerosRomanos.Add("LXVIII", 68);
// 			numerosRomanos.Add("LXIX", 69);
// 			numerosRomanos.Add("LXX", 70);
// 			numerosRomanos.Add("LXXI", 71);
// 			numerosRomanos.Add("LXXII", 72);
// 			numerosRomanos.Add("LXXIII", 73);
// 			numerosRomanos.Add("LXXIV", 74);
// 			numerosRomanos.Add("LXXV", 75);
// 			numerosRomanos.Add("LXXVI", 76);
// 			numerosRomanos.Add("LXXVII", 77);
// 			numerosRomanos.Add("LXXVIII", 78);
// 			numerosRomanos.Add("LXXIX", 79);
// 			numerosRomanos.Add("LXXX", 80);
// 			numerosRomanos.Add("LXXXI", 81);
// 			numerosRomanos.Add("LXXXII", 82);
// 			numerosRomanos.Add("LXXXIII", 83);
// 			numerosRomanos.Add("LXXXIV", 84);
// 			numerosRomanos.Add("LXXXV", 85);
// 			numerosRomanos.Add("LXXXVI", 86);
// 			numerosRomanos.Add("LXXXVII", 87);
// 			numerosRomanos.Add("LXXXVIII", 88);
// 			numerosRomanos.Add("LXXXIX", 89);
// 			numerosRomanos.Add("XC", 90);
// 			numerosRomanos.Add("XCI", 91);
// 			numerosRomanos.Add("XCII", 92);
// 			numerosRomanos.Add("XCIII", 93);
// 			numerosRomanos.Add("XCIV", 94);
// 			numerosRomanos.Add("XCV", 95);
// 			numerosRomanos.Add("XCVI", 96);
// 			numerosRomanos.Add("XCVII", 97);
// 			numerosRomanos.Add("XCVIII", 98);
// 			numerosRomanos.Add("XCIX", 99);
// 			numerosRomanos.Add("C", 100);
// 			numerosRomanos.Add("CI", 101);
// 			numerosRomanos.Add("CII", 102);
// 			numerosRomanos.Add("CIII", 103);
// 			numerosRomanos.Add("CIV", 104);
// 			numerosRomanos.Add("CV", 105);
// 			numerosRomanos.Add("CVI", 106);
// 			numerosRomanos.Add("CVII", 107);
// 			numerosRomanos.Add("CVIII", 108);
// 			numerosRomanos.Add("CIX", 109);
// 			numerosRomanos.Add("CX", 110);
// 			numerosRomanos.Add("CXI", 111);
// 			numerosRomanos.Add("CXII", 112);
// 			numerosRomanos.Add("CXIII", 113);
// 			numerosRomanos.Add("CXIV", 114);
// 			numerosRomanos.Add("CXV", 115);
// 			numerosRomanos.Add("CXVI", 116);
// 			numerosRomanos.Add("CXVII", 117);
// 			numerosRomanos.Add("CXVIII", 118);
// 			numerosRomanos.Add("CXIX", 119);
// 			numerosRomanos.Add("CXX", 120);
// 			numerosRomanos.Add("CXXI", 121);
// 			numerosRomanos.Add("CXXII", 122);
// 			numerosRomanos.Add("CXXIII", 123);
// 			numerosRomanos.Add("CXXIV", 124);
// 			numerosRomanos.Add("CXXV", 125);
// 			numerosRomanos.Add("CXXVI", 126);
// 			numerosRomanos.Add("CXXVII", 127);
// 			numerosRomanos.Add("CXXVIII", 128);
// 			numerosRomanos.Add("CXXIX", 129);
// 			numerosRomanos.Add("CXXX", 130);
// 			numerosRomanos.Add("CXXXI", 131);
// 			numerosRomanos.Add("CXXXII", 132);
// 			numerosRomanos.Add("CXXXIII", 133);
// 			numerosRomanos.Add("CXXXIV", 134);
// 			numerosRomanos.Add("CXXXV", 135);
// 			numerosRomanos.Add("CXXXVI", 136);
// 			numerosRomanos.Add("CXXXVII", 137);
// 			numerosRomanos.Add("CXXXVIII", 138);
// 			numerosRomanos.Add("CXXXIX", 139);
// 			numerosRomanos.Add("CXL", 140);
// 			numerosRomanos.Add("CXLI", 141);
// 			numerosRomanos.Add("CXLII", 142);
// 			numerosRomanos.Add("CXLIII", 143);
// 			numerosRomanos.Add("CXLIV", 144);
// 			numerosRomanos.Add("CXLV", 145);
// 			numerosRomanos.Add("CXLVI", 146);
// 			numerosRomanos.Add("CXLVII", 147);
// 			numerosRomanos.Add("CXLVIII", 148);
// 			numerosRomanos.Add("CXLIX", 149);
// 			numerosRomanos.Add("CL", 150);
// 			numerosRomanos.Add("CLI", 151);
// 			numerosRomanos.Add("CLII", 152);
// 			numerosRomanos.Add("CLIII", 153);
// 			numerosRomanos.Add("CLIV", 154);
// 			numerosRomanos.Add("CLV", 155);
// 			numerosRomanos.Add("CLVI", 156);
// 			numerosRomanos.Add("CLVII", 157);
// 			numerosRomanos.Add("CLVIII", 158);
// 			numerosRomanos.Add("CLIX", 159);
// 			numerosRomanos.Add("CLX", 160);
// 			numerosRomanos.Add("CLXI", 161);
// 			numerosRomanos.Add("CLXII", 162);
// 			numerosRomanos.Add("CLXIII", 163);
// 			numerosRomanos.Add("CLXIV", 164);
// 			numerosRomanos.Add("CLXV", 165);
// 			numerosRomanos.Add("CLXVI", 166);
// 			numerosRomanos.Add("CLXVII", 167);
// 			numerosRomanos.Add("CLXVIII", 168);
// 			numerosRomanos.Add("CLXIX", 169);
// 			numerosRomanos.Add("CLXX", 170);
// 			numerosRomanos.Add("CLXXI", 171);
// 			numerosRomanos.Add("CLXXII", 172);
// 			numerosRomanos.Add("CLXXIII", 173);
// 			numerosRomanos.Add("CLXXIV", 174);
// 			numerosRomanos.Add("CLXXV", 175);
// 			numerosRomanos.Add("CLXXVI", 176);
// 			numerosRomanos.Add("CLXXVII", 177);
// 			numerosRomanos.Add("CLXXVIII", 178);
// 			numerosRomanos.Add("CLXXIX", 179);
// 			numerosRomanos.Add("CLXXX", 180);
// 			numerosRomanos.Add("CLXXXI", 181);
// 			numerosRomanos.Add("CLXXXII", 182);
// 			numerosRomanos.Add("CLXXXIII", 183);
// 			numerosRomanos.Add("CLXXXIV", 184);
// 			numerosRomanos.Add("CLXXXV", 185);
// 			numerosRomanos.Add("CLXXXVI", 186);
// 			numerosRomanos.Add("CLXXXVII", 187);
// 			numerosRomanos.Add("CLXXXVIII", 188);
// 			numerosRomanos.Add("CLXXXIX", 189);
// 			numerosRomanos.Add("CXC", 190);
// 			numerosRomanos.Add("CXCI", 191);
// 			numerosRomanos.Add("CXCII", 192);
// 			numerosRomanos.Add("CXCIII", 193);
// 			numerosRomanos.Add("CXCIV", 194);
// 			numerosRomanos.Add("CXCV", 195);
// 			numerosRomanos.Add("CXCVI", 196);
// 			numerosRomanos.Add("CXCVII", 197);
// 			numerosRomanos.Add("CXCVIII", 198);
// 			numerosRomanos.Add("CXCIX", 199);
// 			numerosRomanos.Add("CC", 200);
// 			numerosRomanos.Add("D", 500);
// 			numerosRomanos.Add("M", 1000);


// 			//Inicia a lista para ler a sequência dos números romanos
// 			var valor = "XX";
// 			var elementos = new List<string>();
			
// 			for (int i = 0; i <= valor.Length; i++) 
// 			{
// 				var x = valor.Substring(0, i);
// 				elementos.Add(x);
// 			}

// 			// Meu valor recebe o numero de entrada
// 			var meuValor = numerosRomanos[valor];
// 			//Busca a resposta por extenso em contagem
// 			var resposta = contagem[meuValor -1];
// 			Console.WriteLine(resposta);


// 			// string numeroRomano;
// 			// // numeroRomano = Console.ReadLine();

			
			

			
			

      
			
			
// 			// var meuValor = numerosRomanos[valor];

// 			// // 

// 			// 

// 			// if (meuValor == ) {
// 			// 	Console.WriteLine("verdadeiro");
// 			// } else {
// 			// 	Console.WriteLine("falso");
// 			// }

// 		}

// 		private int TransformaRomanoEmInteiro(string valor) {
// 			//Inicia conversão de numero string para inteiro
// 			int converterNumero = Int32.Parse(valor);
// 			//Fim da conversão para número inteiro
// 			return converterNumero;
// 		}

// 		private string EscreveInteiroEmExtenso(int inteiro) {
// 			return "string";
// 		}