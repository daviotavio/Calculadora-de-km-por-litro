using System;

namespace km_por_litro
{
    class Program
    {
        static void Main(string[] args)
        {
            int kmPorLitro = 12;
            int distancia;
            int quantidade;

            Console.Write("Qual a distância que você irá percorrer? ");
            distancia = int.Parse(Console.ReadLine());
            //distancia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Seu carro faz " +kmPorLitro +" km por litro de gasolina, e ");
            
            quantidade = distancia / kmPorLitro;

            Console.Write("a quantidade de gasolina necessária é: " +quantidade+ " litros.");
        }
    }
}
