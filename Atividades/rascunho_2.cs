// // dynamic[] contagem = {
// // 				"um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez",
// // 				"onze", "doze", "treze", "catorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove", "vinte",
// // 				"trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa", "cem",
// // 				"duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos", 
// // 				"mil"
// // 			};

// // 			//relacionamento entre numero Romano com Números
// // 			var numerosRomanos =  new Dictionary<string, int>();

// // 			/* Dictionary
// // 			Propriedades:

// // 			Count						Obtém o número total de elementos no Dictionary<TKey,TValue>.
// //  			IsReadOnly			Retorna um booleano indicando se o Dictionary<TKey,TValue> é somente leitura.
// //  			Item						Obtém ou define o elemento com a chave especificada no Dictionary<TKey,TValue>.
// //  			Keys						Retorna a coleção de chaves do Dictionary<TKey,TValue>
// //  			Values					Retorna a coleta de valores no Dictionary<TKey,TValue>.


// // 			Métodos:

// // 			Add							Adiciona um item à coleção Dictionary.
// // 			Add							Adiciona pares de valores-chave na coleção Dictionary<TKey,TValue>.
// // 			Remove					Remove a primeira ocorrência do item especificado do Dictionary<TKey,TValue>.
// // 			Remove					Remove o elemento com a chave especificada.
// // 			ContainsKey			Verifica se a chave especificada existe em Dictionary<TKey,TValue>.
// // 			ContainsValue		Verifica se o valor especificado existe em Dictionary<TKey,TValue>.
// // 			Clear						Remove todos os elementos do Dictionary<TKey,TValue>.
// // 			TryGetValue			Retorna true e atribui o valor com a chave especificada, se a chave não existir, retorna false.
// // 			*/

//         /*
//         numerosPorExtenso.Add(11, "Onze");
// 			numerosPorExtenso.Add(12, "Doze");
// 			numerosPorExtenso.Add(13, "Treze");
// 			numerosPorExtenso.Add(14, "Quatorze");
// 			numerosPorExtenso.Add(14, "Quinze");
// 			numerosPorExtenso.Add(16, "Dezesseis");
// 			numerosPorExtenso.Add(17, "Dezessete");
// 			numerosPorExtenso.Add(18, "Dezoito");
// 			numerosPorExtenso.Add(19, "Dezenove");
// 			numerosPorExtenso.Add(20, "Vinte");
// 			numerosPorExtenso.Add(21, "Vinte e um");
// 			numerosPorExtenso.Add(22, "Vinte e dois");
// 			numerosPorExtenso.Add(23, "Vinte e três");
// 			numerosPorExtenso.Add(24, "Vinte e quatro");
// 			numerosPorExtenso.Add(25, "Vinte e cinco");
// 			numerosPorExtenso.Add(26, "Vinte e seis");
// 			numerosPorExtenso.Add(27, "Vinte e sete");
// 			numerosPorExtenso.Add(28, "Vinte e oito");
// 			numerosPorExtenso.Add(29, "Vinte e nove");
// 			numerosPorExtenso.Add(30, "Trinta");
// 			numerosPorExtenso.Add(31, "Trinta e um");
// 			numerosPorExtenso.Add(32, "Trinta e dois");
// 			numerosPorExtenso.Add(33, "Trinta e três");
// 			numerosPorExtenso.Add(34, "Trinta e quatro");
// 			numerosPorExtenso.Add(35, "Trinta e cinco");
// 			numerosPorExtenso.Add(36, "Trinta e seis");
// 			numerosPorExtenso.Add(37, "Trinta e sete");
// 			numerosPorExtenso.Add(38, "Trinta e oito");
// 			numerosPorExtenso.Add(39, "Trinta e nove");
// 			numerosPorExtenso.Add(40, "Quarenta");
// 			numerosPorExtenso.Add(41, "Quarenta e um");
// 			numerosPorExtenso.Add(42, "Quarenta e dois");
// 			numerosPorExtenso.Add(43, "Quarenta e três");
// 			numerosPorExtenso.Add(44, "Quarenta e quatro");
// 			numerosPorExtenso.Add(45, "Quarenta e cinco");
// 			numerosPorExtenso.Add(46, "Quarenta e seis");
// 			numerosPorExtenso.Add(47, "Quarenta e sete");
// 			numerosPorExtenso.Add(48, "Quarenta e oito");
// 			numerosPorExtenso.Add(49, "Quarenta e nove");
// 			numerosPorExtenso.Add(50, "Cinquenta");
// 			numerosPorExtenso.Add(51, "Cinquenta e um");
// 			numerosPorExtenso.Add(52, "Cinquenta e dois");
// 			numerosPorExtenso.Add(53, "Cinquenta e três");
// 			numerosPorExtenso.Add(54, "Cinquenta e quatro");
// 			numerosPorExtenso.Add(55, "Cinquenta e cinco");
// 			numerosPorExtenso.Add(56, "Cinquenta e seis");
// 			numerosPorExtenso.Add(57, "Cinquenta e sete");
// 			numerosPorExtenso.Add(58, "Cinquenta e oito");
// 			numerosPorExtenso.Add(59, "Cinquenta e nove");
// 			numerosPorExtenso.Add(60, "Sessenta");
// 			numerosPorExtenso.Add(61, "Sessenta e um");
// 			numerosPorExtenso.Add(62, "Sessenta e dois");
// 			numerosPorExtenso.Add(63, "Sessenta e três");
// 			numerosPorExtenso.Add(64, "Sessenta e quatro");
// 			numerosPorExtenso.Add(65, "Sessenta e cinco");
// 			numerosPorExtenso.Add(66, "Sessenta e seis");
// 			numerosPorExtenso.Add(67, "Sessenta e sete");
// 			numerosPorExtenso.Add(68, "Sessenta e oito");
// 			numerosPorExtenso.Add(69, "Sessenta e nove");
// 			numerosPorExtenso.Add(70, "Setenta");
// 			numerosPorExtenso.Add(71, "Setenta e um");
// 			numerosPorExtenso.Add(72, "Setenta e dois");
// 			numerosPorExtenso.Add(73, "Setenta e três");
// 			numerosPorExtenso.Add(74, "Setenta e quatro");
// 			numerosPorExtenso.Add(75, "Setenta e cinco");
// 			numerosPorExtenso.Add(76, "Setenta e seis");
// 			numerosPorExtenso.Add(77, "Setenta e sete");
// 			numerosPorExtenso.Add(78, "Stenta e oito");
// 			numerosPorExtenso.Add(79, "Setenta e nove");
// 			numerosPorExtenso.Add(80, "Oitenta");
// 			numerosPorExtenso.Add(81, "Oitenta e um");
// 			numerosPorExtenso.Add(82, "Oitenta e dois");
// 			numerosPorExtenso.Add(83, "Oitenta e três");
// 			numerosPorExtenso.Add(84, "Oitenta e quatro");
// 			numerosPorExtenso.Add(85, "Oitenta e cinco");
// 			numerosPorExtenso.Add(86, "Oitenta e seis");
// 			numerosPorExtenso.Add(87, "Oitenta e sete");
// 			numerosPorExtenso.Add(88, "Oitenta e oito");
// 			numerosPorExtenso.Add(89, "Oitenta e nove");
// 			numerosPorExtenso.Add(90, "Noventa");
// 			numerosPorExtenso.Add(91, "Noventa e um");
// 			numerosPorExtenso.Add(92, "Noventa e dois");
// 			numerosPorExtenso.Add(93, "Noventa e três");
// 			numerosPorExtenso.Add(94, "Noventa e quatro");
// 			numerosPorExtenso.Add(95, "Noventa e cinco");
// 			numerosPorExtenso.Add(96, "Noventa e seis");
// 			numerosPorExtenso.Add(97, "Noventa e sete");
// 			numerosPorExtenso.Add(98, "Noventa e oito");
// 			numerosPorExtenso.Add(99, "Noventa e nove");
// 			numerosPorExtenso.Add(100, "Cem");
// 			numerosPorExtenso.Add(101, "Cento e um");
// 			numerosPorExtenso.Add(102, "Cento e dois");
// 			numerosPorExtenso.Add(103, "Cento e três");
// 			numerosPorExtenso.Add(104, "Cento e quatro");
// 			numerosPorExtenso.Add(105, "Cento e cinco");
// 			numerosPorExtenso.Add(106, "Cento e seis");
// 			numerosPorExtenso.Add(107, "Cento e sete");
// 			numerosPorExtenso.Add(108, "Cento e oito");
// 			numerosPorExtenso.Add(109, "Cento e nove");
// 			numerosPorExtenso.Add(110, "Cento e dez");
// 			numerosPorExtenso.Add(111, "Cento e onze");
// 			numerosPorExtenso.Add(112, "Cento e doze");
// 			numerosPorExtenso.Add(113, "Cento e treze");
// 			numerosPorExtenso.Add(114, "Cento e quatorze");
// 			numerosPorExtenso.Add(115, "Cento e quinze");
// 			numerosPorExtenso.Add(116, "Cento e dezesseis");
// 			numerosPorExtenso.Add(117, "Cento e dezessete");
// 			numerosPorExtenso.Add(118, "Cento e dezoito");
// 			numerosPorExtenso.Add(119, "Cento e dezenove");
// 			numerosPorExtenso.Add(120, "Cento e vinte");
// 			numerosPorExtenso.Add(121, "Cento e vinte e um");
// 			numerosPorExtenso.Add(122, "Cento e vinte e dois");
// 			numerosPorExtenso.Add(123, "Cento e vinte e três");
// 			numerosPorExtenso.Add(124, "Cento e vinte  equatro");
// 			numerosPorExtenso.Add(125, "Cento e vinte e cinco");
// 			numerosPorExtenso.Add(126, "Cento e vinte e seis");
// 			numerosPorExtenso.Add(127, "Cento e vinte e sete");
// 			numerosPorExtenso.Add(128, "Cento e vinte e oito");
// 			numerosPorExtenso.Add(129, "Cento e vinte e nove");
// 			numerosPorExtenso.Add(130, "Cento e trinta");
// 			numerosPorExtenso.Add(131, "Cento e trinta e um");
// 			numerosPorExtenso.Add(132, "Cento e trinta e dois");
// 			numerosPorExtenso.Add(133, "Cento e trinta e três");
// 			numerosPorExtenso.Add(134, "Cento e trinta e quatro");
// 			numerosPorExtenso.Add(135, "Cento e trinta e cinco");
// 			numerosPorExtenso.Add(136, "Cento e trinta e seis");
// 			numerosPorExtenso.Add(137, "Cento e trinta e sete");
// 			numerosPorExtenso.Add(138, "Cento e trinta e oito");
// 			numerosPorExtenso.Add(139, "Cento e trinta e nove");
// 			numerosPorExtenso.Add(140, "Quarenta");
// 			numerosPorExtenso.Add(141, "Cento e quarenta e um");
// 			numerosPorExtenso.Add(142, "Cento e quarenta e dois");
// 			numerosPorExtenso.Add(143, "Cento e quarenta e três");
// 			numerosPorExtenso.Add(144, "Cento e quarenta e quatro");
// 			numerosPorExtenso.Add(145, "Cento e quarenta e cinco");
// 			numerosPorExtenso.Add(146, "Cento e quarenta e seis");
// 			numerosPorExtenso.Add(147, "Cento e quarenta e sete");
// 			numerosPorExtenso.Add(148, "Cento e quarenta e oito");
// 			numerosPorExtenso.Add(149, "Cento e quarenta e nove");
// 			numerosPorExtenso.Add(150, "Cinquenta");
// 			numerosPorExtenso.Add(151, "Cento e cinquenta e um");
// 			numerosPorExtenso.Add(152, "Cento e cinquenta e dois");
// 			numerosPorExtenso.Add(153, "Cento e cinquenta e três");
// 			numerosPorExtenso.Add(154, "Cento e cinquenta e quatro");
// 			numerosPorExtenso.Add(155, "Cento e cinquenta e cinco");
// 			numerosPorExtenso.Add(156, "Cento e cinquenta e seis");
// 			numerosPorExtenso.Add(157, "Cento e cinquenta e sete");
// 			numerosPorExtenso.Add(158, "Cento e cinquenta e oito");
// 			numerosPorExtenso.Add(159, "Cento e cinquenta e nove");
// 			numerosPorExtenso.Add(160, "Sessenta");
// 			numerosPorExtenso.Add(161, "Cento e sessenta e um");
// 			numerosPorExtenso.Add(162, "Cento e sessenta e dois");
// 			numerosPorExtenso.Add(163, "Cento e sessenta e três");
// 			numerosPorExtenso.Add(164, "Cento e sessenta e quatro");
// 			numerosPorExtenso.Add(165, "Cento e sessenta e cinco");
// 			numerosPorExtenso.Add(166, "Cento e sessenta e seis");
// 			numerosPorExtenso.Add(167, "Cento e sessenta e sete");
// 			numerosPorExtenso.Add(168, "Cento e sessenta e oito");
// 			numerosPorExtenso.Add(169, "Cento e sessenta e nove");
// 			numerosPorExtenso.Add(170, "Setenta");
// 			numerosPorExtenso.Add(171, "Cento e setenta e um");
// 			numerosPorExtenso.Add(172, "Cento e setenta e dois");
// 			numerosPorExtenso.Add(173, "Cento e setenta e três");
// 			numerosPorExtenso.Add(174, "Cento e setenta e quatro");			
// 			numerosPorExtenso.Add(175, "Cento e setenta e cinco");
// 			numerosPorExtenso.Add(176, "Cento e setenta e seis");
// 			numerosPorExtenso.Add(177, "Cento e setenta e sete");
// 			numerosPorExtenso.Add(178, "Cento e setenta e oito");
// 			numerosPorExtenso.Add(179, "Cento e setenta e nove");
// 			numerosPorExtenso.Add(180, "Oitenta");
// 			numerosPorExtenso.Add(181, "Cento e oitenta e um");
// 			numerosPorExtenso.Add(182, "Cento e oitenta e dois");
// 			numerosPorExtenso.Add(183, "Cento e oitenta e três");
// 			numerosPorExtenso.Add(184, "Cento e oitenta e quatro");
// 			numerosPorExtenso.Add(185, "Cento e oitenta e cinco");
// 			numerosPorExtenso.Add(186, "Cento e oitenta e seis");
// 			numerosPorExtenso.Add(187, "Cento e oitenta e sete");
// 			numerosPorExtenso.Add(188, "Cento e oitenta e oito");
// 			numerosPorExtenso.Add(189, "Cento e oitenta e nove");
// 			numerosPorExtenso.Add(190, "Noventa");
// 			numerosPorExtenso.Add(191, "Cento e noventa e um");
// 			numerosPorExtenso.Add(192, "Cento e noventa e dois");
// 			numerosPorExtenso.Add(193, "Cento e noventa e três");
// 			numerosPorExtenso.Add(194, "Cento e noventa e quatro");
// 			numerosPorExtenso.Add(195, "Cento e noventa e cinco");
// 			numerosPorExtenso.Add(196, "Cento e noventa e seis");
// 			numerosPorExtenso.Add(197, "Cento e noventa e sete");
// 			numerosPorExtenso.Add(198, "Cento e noventa e oito");
// 			numerosPorExtenso.Add(199, "Cento e noventa e nove");
// 			numerosPorExtenso.Add(200, "Duzentos");
// 			numerosPorExtenso.Add(201, "Duzentos e um");
// 			numerosPorExtenso.Add(202, "Duzentos e dois");
// 			numerosPorExtenso.Add(203, "Duzentos e três");
// 			numerosPorExtenso.Add(204, "Duzentos e quatro");
// 			numerosPorExtenso.Add(205, "Duzentos e cinco");
// 			numerosPorExtenso.Add(206, "Duzentos e seis");
// 			numerosPorExtenso.Add(207, "Duzentos e sete");
// 			numerosPorExtenso.Add(208, "Duzentos e oito");
// 			numerosPorExtenso.Add(209, "Duzentos e nove");
// 			numerosPorExtenso.Add(210, "Duzentos");
// 			numerosPorExtenso.Add(211, "Duzentos e onze");
// 			numerosPorExtenso.Add(212, "Duzentos e doze");
// 			numerosPorExtenso.Add(213, "Duzentos e treze");
// 			numerosPorExtenso.Add(214, "Duzentos e catorze");
// 			numerosPorExtenso.Add(215, "Duzentos cinco");
// 			numerosPorExtenso.Add(216, "Duzentos seis");
// 			numerosPorExtenso.Add(217, "Duzentos sete");
// 			numerosPorExtenso.Add(218, "Duzentos oito");
// 			numerosPorExtenso.Add(219, "Duzentos nove");

//         */


// // 			//na a sta para er a sequêna dos números romanos
// // 			ar vaor = "XX";
// // 			var eementos = new ist<string>();
			
// // 			for (int i = 0; i <= vaor.Length; i++) 
// // 			{
// // 				var x = valor.Substring(0, i);
// // 				elementos.Add(x);
// // 			}

// // 			// Meu valor reebe o numero de entrada
// // 			var meuValor = numerosRomanos[valor];
// // 			//Busa a resposta por extenso em ontagem
// // 			var resposta = contagem[meuValor -1];
// // 			Console.WriteLine(resposta);


// // 			// string numeroRomano;
// // 			// // numeroRomano = Console.ReadLine();

			
// // 			// var meuValor = numerosRomanos[valor];

// // 			// // 

// // 			// 

// // 			// if (meuValor == ) {
// // 			// 	Console.WriteLine("verdadeiro");
// // 			// } else {
// // 			// 	Console.WriteLine("falso");
// // 			// }

// // 		}

// // 		private int TransformaRomanoEmInteiro(string valor) {
// // 			//Inicia conversão de numero string para inteiro
// // 			int converterNumero = Int32.Parse(valor);
// // 			//Fim da conversão para número inteiro
// // 			return converterNumero;
// // 		}

// // 		private string EscreveInteiroEmExtenso(int inteiro) {
// // 			return "string";
// // 		}