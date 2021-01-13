using System;

namespace operacao_matematica
{
    class Program
    {
        static void Main(string[] args)
        {

            Matematica matematica = new Matematica();
            
            // int soma = matematica.Soma(366,40);
            // Console.WriteLine(soma);

            // int subtracao = matematica.Subtrai(370,40);
            // Console.WriteLine(subtracao);

            int multiplicacao = matematica.Multiplica(5,5);
            Console.WriteLine(multiplicacao);

            int exponenciacao = matematica.Exponencia(2,3);
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
                if(primeiroValor < segundoValor){ 
                    for (int i = primeiroValor; i < segundoValor; i++) {
                        cont++;
                    }
                } 
                else 
                {
                    for (int i = segundoValor; i < primeiroValor; i++) {
                        cont++;
                    }
                }
                return cont;
            }

            //Multiplica dois números
            public int Multiplica(int multiplicando, int multiplicador) {
                // var calculo = 0;
                var multiplicacao = 0;

                for (int i = 0; i < multiplicador; i++) {
                    multiplicacao = multiplicacao + multiplicando;  
                }

                return multiplicacao;
            }
            public int Exponencia(int numeroBase, int expoente) {
        
                var resultado = numeroBase;
                for (int cont = 0; cont < expoente -1; cont++) {
                    resultado = Multiplica(resultado, numeroBase);
                    //aux = resultado;
                    // for (int i = 0; i < numeroBase; i++) {
                    //  resultado = resultado + numeroBase;  
                    // }
                }

                return resultado;
            }
        }

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