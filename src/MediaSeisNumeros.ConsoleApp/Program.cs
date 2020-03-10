using System;
using System.Collections.Generic;
using System.Linq;

namespace MediaSeisNumeros.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaNumeros = new List<double>();
            for (int i = 0; i < 4; i++)
            {
               var numeroRequisitado = i + 1;     
               Console.WriteLine($"Digite a nota do Bimestre {numeroRequisitado}:");
               var numero = Console.ReadLine();
               double.TryParse(numero, out var numerodouble);

               listaNumeros.Add(numerodouble);  
            }

            Console.WriteLine("Digite a quantidade de aulas: ");
            var total_aulas = Console.ReadLine();
            
            Console.WriteLine("Digite a quantidade total de presença do aluno: ");
            var total_presenca = Console.ReadLine();

            double perc_presenca = (double.Parse(total_presenca) / double.Parse(total_aulas)) * 100;
            
            var media = listaNumeros.Average();        

            string aprovadoReprovado = "";
            if ((media >= 5) && (perc_presenca >= 75))
                aprovadoReprovado = "Aprovado";
            else 
                aprovadoReprovado = "Reprovado";

           Console.WriteLine($"O Aluno foi {aprovadoReprovado} com a média: {Math.Round(media, 2)} e percentual de presenca de: {Math.Round(perc_presenca, 2)}");

        }
    }
}
