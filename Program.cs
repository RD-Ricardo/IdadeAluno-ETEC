using System;
using Humanizer;

namespace IdadeAluno
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Data de nascimento
            DateTime anosNascimento = new DateTime(2004, 08 , 04);
            string diaNascimento = anosNascimento.ToString("dddd"); 
            string ano = anosNascimento.ToOrdinalWords(); 
            //Data de aniversario de 18 anos
            DateTime anoAniversario = anosNascimento.AddYears(18).Date;
            string anoA = anoAniversario.ToOrdinalWords(); 
            string diaTextoA = anoAniversario.ToString("dddd"); 
            Console.WriteLine("------------------");
            Console.WriteLine("--Idade do Aluno--");
            Console.WriteLine("------------------");
            Console.WriteLine($"Eu nasci em {diaNascimento} {ano}");
            Console.WriteLine($"Aniverário de 18 anos em {diaTextoA}, {anoA}");
        }
    }
}
