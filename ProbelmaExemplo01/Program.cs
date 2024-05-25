using System;
using System.Globalization;

namespace ProblemaExemplo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cultura = CultureInfo.InvariantCulture;
            Produto a = new Produto("Caneca", 15.00, 20 );

            Console.WriteLine( a.ToString() );
            Console.WriteLine( a.GetNome() );
            Console.WriteLine(  );

            Console.WriteLine( "Insira um novo nome para o 'produto'" );
            string NovoNome = Console.ReadLine();
            a.SetNome( NovoNome );

            Console.WriteLine( a.ToString() );
            Console.WriteLine( a.GetNome() );
            Console.WriteLine( a.GetPreco().ToString("f2", cultura) );
            Console.WriteLine( a.GetQuantidade() );
        }
    }
}


