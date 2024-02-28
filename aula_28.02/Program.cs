using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_28._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario;
            //leitura do salario
            Console.WriteLine("Digite o valor do salario");
            salario = float.Parse (Console.ReadLine());

            salario = salario + (25.0f /100.0f) + salario;

            Console.WriteLine("o novo salario é R${0}", salario);
            Console.ReadKey();
        
        }
    }
}
