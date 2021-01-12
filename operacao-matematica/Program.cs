using System;

namespace operacao_matematica
{
    class Program
    {
        static void Main(string[] args)
        {

            Matematica matematica = new Matematica();
            
            int soma = matematica.Soma(366,40);
            Console.WriteLine(soma);

            int subtracao = matematica.Subtrai(370,40);
            Console.WriteLine(subtracao);

            int multiplicacao = matematica.Multiplica(90,112);
            Console.WriteLine(multiplicacao);
            
            int exponenciacao = matematica.Exponencia(3,3);
            Console.WriteLine(multiplicacao);

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
                var cont = 0;
                var armazenaPrimeiroValor = multiplicando;

                for (int i = 0; i < multiplicador; i++) {
                    multiplicacao = multiplicacao + multiplicando;  
                }

                return multiplicacao;
            }
            public int Exponencia(int numeroBase, int expoente) {
        
                var resultado = 0;
                // var cont = 0;
                var armazenaPrimeiroValor = numeroBase;

                for (int cont = 0; cont < expoente; cont++) {
                    for (int i = 0; i < numeroBase; i++) {
                        resultado = resultado + numeroBase;  
                    }
                }

                return resultado;
            }
        }

    }
    
}
