using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaciona
{
    internal class Estacionamento
    {
        public double ValorInical { get; set; }
        public double ValorPorHora { get; set; }

        List<string> Veiculo = new List<string>();

        public Estacionamento(double valorInical, double valorPorHora)
        {
            ValorInical = valorInical;
            ValorPorHora = valorPorHora;
        }

        public Estacionamento(List<string> veiculo)
        {
            Veiculo = veiculo;
        }

        public void CadastrarVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para estacionar:");
            string NomeVeiculo = Console.ReadLine();
            Veiculo.Add(NomeVeiculo);
            Console.WriteLine();
        }

        public double CalculoDoTempo(double horas)
        {
            return ValorPorHora * horas + ValorInical; 
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para Remover:");
            string NomeVeiculo = Console.ReadLine();
            Veiculo.FindAll(x => x .Equals(NomeVeiculo));
            Veiculo.Remove(NomeVeiculo);
            Console.WriteLine("Digite a quantidade de hoaras que o veiculo permaneceu parado: ");
            double horas = double.Parse(Console.ReadLine());
            var valor = CalculoDoTempo(horas);
            Console.WriteLine($"O veiculo {NomeVeiculo} foi removido e o preco total foi de: R$ {valor}");
            Console.WriteLine();
        }

        public void MostrarVeiculos()
        {
            Console.WriteLine("Os veiculos sao: ");
            foreach (var i in Veiculo)
            {
                Console.WriteLine(i);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

  
    }
}
