using System;

namespace atividade_3_media_ponderada
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Verifica se o Aluno foi aprovado.

            Crie uma classe para comportar uma função que realize o calculo de média ponderada de quatro valores e que retorne “Baixo”, “Ideal” ou “”Alto para os seguintes casos:

            1. Se o valor da média ponderada for < 7.5 retorna ”Baixo”;
            2. Se for maior ou igual a 7.5 e menor ou igual a 8.5 retorna “Ideal”;
            3. Se for maior que 8.5 deve retornar o valor “Alto”;
            */

            MediaPonderada media = new MediaPonderada();

            double resultadoMedia = media.Media(10, 6.5, 7, 8.25);
            string resposta = "";
            
            if (resultadoMedia == 0)
            {
                resposta = "Opa! Por favor, escreva um número entre 0 e 10.";
            }
            else if (resultadoMedia < 7.5)
            {
                resposta = "Baixo";
            }
            else if (resultadoMedia >= 7.5 && resultadoMedia < 8.5 )
            {
                resposta = "Ideal";
            }
            else
            {
                resposta = "Alto";
            }
            Console.WriteLine(resposta);
            
        }

        class MediaPonderada
        {
            public double Media(double primeiraNota, double segundaNota, double terceiraNota, double quartaNota)
            {
                //media ponderada = primeiraNota x 1 + segundaNota x 2 + terceiraNota x 3 + quartaNota x 4 / 1 + 2 + 3 + 4
                double calculaNota = 0;
                double nota1 = 0;
                double nota2 = 0;
                double nota3 = 0;
                double nota4= 0;
                int cont = 0;
                double divisor = 0;
                double resultadoFinal = 0;
                
                
                if (primeiraNota < 0 || primeiraNota > 10 || segundaNota < 0 || segundaNota > 10 || 
                    terceiraNota < 0 || terceiraNota > 10 || quartaNota < 0 || quartaNota > 10)
                {
                    return 0;
                }
                else 
                {

                    for (int i = 0; i <= 4; i++) 
                    {   
                        int aux = i + 1;
                        calculaNota = 0;
                        if (i == 0)
                        {
                            calculaNota = primeiraNota * (i+1);
                            nota1 = calculaNota;
                            Console.WriteLine(nota1);
                        }
                        if (i == 1)
                        {
                            calculaNota = segundaNota * (i+1);
                            nota2 = calculaNota;
                            Console.WriteLine(nota2);
                        }
                        if (i == 2)
                        {
                            calculaNota = terceiraNota * (i+1);
                            nota3 = calculaNota;
                            Console.WriteLine(nota3);
                            
                        }
                        if (i == 3)
                        {
                            calculaNota = quartaNota * (i+1);
                            nota4 = calculaNota;
                            Console.WriteLine(nota4);
                        }
                        cont++;
                        divisor = divisor + (cont - 1);
                    }

                    return resultadoFinal = (nota1 + nota2 + nota3 + nota4) / divisor;
                }    
            }

        }
    }
}