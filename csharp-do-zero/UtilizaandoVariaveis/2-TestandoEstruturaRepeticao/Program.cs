using System;

namespace TestandoEstruturaRepeticao
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i <= 4; i++)
            {
                for (int j = i; j <= 4; j++)
                Console.Write("* ");
                Console.Write("\n");
            }
        }
    }
}
