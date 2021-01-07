using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class UsandoDynamic : IAulaItem
    {
        public void Executar()
        {
            string a = "Certificação C#";
            var v = "Certificação C#";
            object o = "Certificação C#";

            Console.WriteLine(a);
            Console.WriteLine(v);
            Console.WriteLine(o);

            // Convertendo as variáveis para uppercase

            a = a.ToUpper();
            v = v.ToUpper();
            o = ((string)o).ToUpper();

            Console.WriteLine(a);
            Console.WriteLine(v);
            Console.WriteLine(o);

            //Atribuindo tipos diferentes às variáveis

            // a = 123;
            //v = 123;
            o = 123;

            o = (int)o + 4;

            Console.WriteLine(o);

            //Trabalhando com o tipo dynamic

            dynamic d = "Certificação C#";

            Console.WriteLine(d);

            d = d.ToUpper();
            Console.WriteLine(d);
        }
    }
}
