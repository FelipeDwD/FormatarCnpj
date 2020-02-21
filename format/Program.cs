using System;

namespace format
{
    class Program
    {
        static void Main(string[] args)
        {
            string cnpjNumerico = "08575666000180";
            Console.WriteLine("Cnpj somente números: " + cnpjNumerico);          
            string cnpj = cnpjNumerico.Substring(0, 2) + ".";
            cnpj += cnpjNumerico.Substring(2, 3) + ".";
            cnpj += cnpjNumerico.Substring(5, 3) + "/";
            cnpj += cnpjNumerico.Substring(8, 4) + "-";
            cnpj += cnpjNumerico.Substring(12, 2);

            cnpjNumerico = cnpj;
            Console.WriteLine("\n\n\nCnpj: " + cnpjNumerico);
        }
    }
}
