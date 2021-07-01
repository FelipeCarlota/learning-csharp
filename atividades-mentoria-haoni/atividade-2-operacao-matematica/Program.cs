using System;

namespace operacao_matematica
{
    class Program
    {
        static void Main(string[] args)
        {

        /**
        *Criar uma classe Matematica saiba fazer:
        *
        *O nome da classe obrigatoriamente deverá ser “Matematica”	
        *    - Uma soma:
        *        Obrigatóriamente a assinatura do método tem que ser: 
        *            int Soma(int primeiroValor, int segundoValor);
        *        
        *    - Uma subtração:
        *        Obrigatóriamente a assinatura do método tem que ser:
        *            int Subtrai(int primeiroValor, int segundoValor);
        *
        *    - Uma Multiplicação:
        *        Obrigatoriamente a assinatura do método tem que ser:
        *            int Mutiplica(int multiplicando, int multiplicador);
        *
        *    - Uma exponenciação:
        *        Obrigatóriamente a assinatura do método tem que ser:
        *            int Exponencia(int numeroBase, int expoente);
        *
        *
        *O único operador permitido para a confecção de todos os itens deverá ser “+” (operador Soma).É permitido o uso de todos os números racionais e inteiros.
        **/

            Matematica matematica = new Matematica();
            
            int soma = matematica.Soma(20,60);
            Console.WriteLine(soma);

            int subtracao = matematica.Subtrai(7,3);
            Console.WriteLine(subtracao);

            int multiplicacao = matematica.Multiplica(9,3);
            Console.WriteLine(multiplicacao);

            int exponenciacao = matematica.Exponencia(9,3);
            Console.WriteLine(exponenciacao);

        }
        class Matematica {

            // Soma dois números
            public int Soma(int primeiroValor, int segundoValor) {
                return primeiroValor + segundoValor;
            }

            // Subtrai dois números
            public int Subtrai(int primeiroValor, int segundoValor) {   
                int cont = 0;
                int aux = -1;
                // Subtração normal

                for (int i = segundoValor; i < primeiroValor; i++)
                {
                    cont++;
                }

                for (int i = primeiroValor; i < segundoValor; i++)
                {
                    cont = cont + aux;
                }

                return cont;
            }

            //Multiplica dois números
            public int Multiplica(int multiplicando, int multiplicador) {
                // var calculo = 0;
                var multiplicacao = 0;
                int aux = -1;

                // Multiplica positivos
                for (int i = 0; i < multiplicador; i++) {
                    multiplicacao += multiplicando;  
                }
                
                // Multiplica dois números negativos

                if (multiplicando < 0 && multiplicador < 0)
                {
                    int resultado = 0;
                    int cont = 0;
                    // int buscaValor = 0;
                    for (int i = 0; i > multiplicador; i += aux) {
                        resultado = resultado + multiplicando; 
                    }

                    for (int j = 0; j > resultado; j += aux) 
                    {
                        cont++;
                    }
                    multiplicacao = cont;
                }

                // Multiplica com um multiplicando negativo
                if (multiplicando < 0 && multiplicador > 0)
                {
                    for (int i = 0; i > multiplicador; i++) 
                    {
                        multiplicacao = multiplicacao + multiplicando;  
                    }
                } 
                // Multiplica com um multiplicador negativo
                else if (multiplicando > 0 && multiplicador < 0) 
                {
                    int resultado = 0;
                    int cont = 0;
                    for (int i = 0; i > multiplicador; i += aux) 
                    {
                        resultado = resultado + multiplicando;  
                    }

                    for (int j = 0; j < resultado; j++) 
                    {
                        cont = cont + aux;
                    }
                    multiplicacao = cont;
                }


                return multiplicacao;
            }

            public int Exponencia(int numeroBase, int expoente) {

                // int resultadoFinal = 0;
                var resultado = numeroBase;
                for (int cont = 0; cont < expoente -1; cont++) {
                    resultado = Multiplica(resultado, numeroBase);
                }

                // //Chamo a função isPar
                // VerificaPar verificaNumero = new VerificaPar();
                // int isPar = verificaNumero.isPar(expoente);

                // if (numeroBase < 0 && isPar == 0)
                // {
                //     int resultadoAux = Subtrai(resultado, resultado);
                //     resultado = Subtrai(resultadoAux, resultado);
                // }


                return resultado;
                
            }
        }

        // class VerificaPar
        // {
        //     public int isPar( int numero)
        //     {
        //         int isPar = 0;
        //         int verificador = -2;
        //         int aux = -1;

        //         for (int i = numero; i > 1; i+=aux)
        //         {
        //             isPar = i + verificador;
                    
        //             if (isPar == 1)
        //             {
        //                 break;
        //             }
        //         }


        //         return isPar;
        //     }
        // }

    }
    
}


/*
expoente 

5 ^ 2 = 25

5 + 5
  10 + 5
     15 + 5 = 25


3 ^ 7 = 3 . 3 . 3 . 3 . 3 . 3 . 3 = 2187

3 + 3
  6 + 3
     9 + 3
       12 + 3


*/