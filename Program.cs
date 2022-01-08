using System;

namespace _2_UC03
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            DateTime dataNascimento;
            DateTime dataAtual = DateTime.Now;
            TimeSpan resultado;
            int idade;




            Console.WriteLine("Qual seu Nome?");
            nome = Console.ReadLine();


            Console.WriteLine("Qual sua data de nascimento?");
            dataNascimento = DateTime.Parse(Console.ReadLine());

            resultado = dataAtual - dataNascimento;
            idade = resultado.Days /30/12;

            

            if(idade>=18)
            Console.WriteLine("sua senha é: "+ nome+idade);
            if(idade<18)
            Console.WriteLine("sua senha é: "+ idade+nome);

        }
    }
}
