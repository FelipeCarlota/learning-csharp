// var somaExtenso = soma.ToString();
// 				var dezena = 0;

// 				var escritoPorExtenso = "";
				
// 				for (int i = somaExtenso.Length-1; i >= 0 ; i--) {
					
// 					var valorLido = Int32.Parse(somaExtenso.Substring(i, 1));
					
// 					//UNIDADE
// 					if (i == somaExtenso.Length-1) {
						
// 						if (somaExtenso.Length > 1 && valorLido != 0) {
// 							escritoPorExtenso = " e "+ numeroPorExtenso[somaExtenso.Substring(i, 1)];
// 						} else {
// 							escritoPorExtenso = numeroPorExtenso[somaExtenso.Substring(i, 1)];
// 						}
// 					}
// 					//DEZENA
// 					if (i == somaExtenso.Length-2) {
// 						Console.WriteLine(valorLido);
// 						dezena = Int32.Parse(somaExtenso.Substring(i, 2));
// 						if (valorLido == 1) {
// 							escritoPorExtenso = numeroPorExtenso[somaExtenso.Substring(i, 2)];
// 						} else if ( valorLido > 1){
// 							var aux = valorLido * 10;
							
// 							escritoPorExtenso = numeroPorExtenso[aux.ToString()] + escritoPorExtenso;



// 							// if (aux == 50) 
// 							// {
// 							// 	escritoPorExtenso = numeroPorExtenso[aux.ToString()] + escritoPorExtenso;

// 							// // // }
// 							// // else 
// 							// // {
// 							// 	escritoPorExtenso = numeroPorExtenso[aux.ToString()] + " e " +  escritoPorExtenso;
// 							// }
							
// 						}
// 						if (dezena >= 10 && somaExtenso.Length > 2 ) {
// 							escritoPorExtenso = " e " + escritoPorExtenso;
// 						} 
// 					}
					
// 					// Centena
// 					if (i == somaExtenso.Length-3) {
// 						var aux = valorLido * 100;
// 						var centena = Int32.Parse(somaExtenso.Substring(i, 3));
// 						Console.WriteLine(aux);
// 						if (centena > 100 && centena < 200)
// 						{
// 							escritoPorExtenso = "cento " + escritoPorExtenso;
// 						}
// 						else if ( centena == 100) {
// 							escritoPorExtenso = numeroPorExtenso[aux.ToString()];
// 						}
// 						else
// 						{
// 							escritoPorExtenso = numeroPorExtenso[aux.ToString()]+ escritoPorExtenso;
// 						}
// 					}

// 					// Milhares
// 					if (i == somaExtenso.Length-4) { // Tratar o 0 da dezena, centena
// 						var milhar = Int32.Parse(somaExtenso.Substring(i, 4));
// 						dezena = Int32.Parse(somaExtenso.Substring(2, 2));
// 						var aux = valorLido * 1000;
// 							if (dezena == 0) {
// 								escritoPorExtenso = numeroPorExtenso[valorLido.ToString()] +  " mil e " + escritoPorExtenso ;

// 							} else {
// 								escritoPorExtenso = numeroPorExtenso[valorLido.ToString()] +  " mil " + escritoPorExtenso ;
// 							}
// 					}
					
// 				}
// 				Console.WriteLine(escritoPorExtenso); 
// 				// Console.WriteLine($"{milhar} {centena} {dezena} {unidade}"); 
// 			}
// 			else 
// 			{
// 				Console.WriteLine("Erro: Este número está além do nosso limite");
// 			}