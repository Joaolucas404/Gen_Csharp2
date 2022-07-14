using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = ""; 
            double total, altura, peso, idade; 
            Console.WriteLine("Calcular IMC");
            Console.WriteLine("Insira o seu Nome");
            nome = Console.ReadLine();
            Console.WriteLine("Insira sua Idade");
                idade = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Peso");
                peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira Altura");
                altura = double.Parse(Console.ReadLine()); 
                total = peso / (altura * altura);
            Console.WriteLine("total " + total.ToString("F2"));
            if (total < 18.5) 
            Console.WriteLine("Magreza");
            if (total >= 18.5 && total < 24.9) 
            Console.WriteLine("Normal");
            if (total >= 24.9 && total < 30)
            Console.WriteLine("Sobre Peso");
            if (total >= 30) 
            Console.WriteLine("Obesidade");


        }
    }
}
