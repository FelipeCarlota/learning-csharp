// using System;

// namespace atividade_6_jogo_de_adivinhacao
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             /*
//                 Criar um jogo que adivinha um número em 8 tentativas
//             */
//             string Programa = "play";
//             string continuaPrograma = "";
//             Random rand = new Random(1);            
            
//             int[] numeros = new int[100];
            
//             int i = 0;
//             int adivinhaNumero = 0;
//             int contaPassos = 0;

//             while (Programa == "play")
//             {
//                 contaPassos += 1;

//                 for (i = 0; i < numeros.Length; i++)
//                 {  
//                     numeros[i] = i + 1;
//                     Console.Write(numeros[i] + " ");
//                 }
//                 Console.WriteLine();
//                 if (contaPassos == 1)
//                 {
//                     Console.WriteLine(contaPassos);
//                     //Primeira tentativa
//                     Console.WriteLine(adivinhaNumero = 50);
//                     continuaPrograma = ">";
//                 } 

//                 if (contaPassos == 2)
//                 {
//                     if (continuaPrograma == ">")
//                     {   //Primeira tentativa
//                         Console.WriteLine(adivinhaNumero = 75);
//                         continuaPrograma = "=";
//                     } 
//                     else if (continuaPrograma == "<")
//                     {
//                         Console.WriteLine(adivinhaNumero = 25);
//                         continuaPrograma = "<";
//                     }
//                 }   //
                
//                 if (continuaPrograma == ">")
//                 {
//                     i = adivinhaNumero;
//                     Programa = "play";
//                 } 
//                 else if (continuaPrograma == "<")
//                 {
//                     numeros = new int[adivinhaNumero];
//                     Programa = "play";
//                 }
//                 else
//                 {
//                     Console.WriteLine("Nossa, até que infim acertei");
//                     Programa = "exit";
//                 }     
//             }
//         }
//     }
// }
 



//  for(int n = intervalo; n < i; n++)
//             {
//               //Primeira tentativa
//               if (intervalo < i && n == 1)
//               {
//                 intervalo = 50;
//                 Console.WriteLine("O número é: " + intervalo + "?");
//                 string resposta = Console.ReadLine();

//                 if(resposta == ">")
//                 {
//                   return palpite = AdivinhaNumero(intervalo = 50, i = 100);
//                 }
//                 else if(resposta == "<")
//                 {
//                   return palpite = AdivinhaNumero(intervalo = 1, i = 50);
//                 }
//                 Console.WriteLine(intervalo);
//               }
//               // Segunda tentativa
//               if(intervalo < i && n == 2)
//               {
//                 if(intervalo == 50)
//                 {
//                   intervalo = 75;
//                 }
//                 else
//                 {
//                   intervalo = 25;
//                 }
//                 Console.WriteLine("O número é: " + intervalo + "?");
//                 string resposta = Console.ReadLine();

//                 if(resposta == ">")
//                 {
//                   return palpite = AdivinhaNumero(intervalo = 50, i = 100);
//                 }
//                 else if(resposta == "<")
//                 {
//                   return palpite = AdivinhaNumero(intervalo = 1, i = 50);
//                 }
//                 Console.WriteLine(intervalo);
//               }
//             }