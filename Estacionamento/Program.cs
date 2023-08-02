using Estaciona;


Console.WriteLine("Qual o valor inicial?");
double ValorInicial = double.Parse(Console.ReadLine());
Console.WriteLine("Qual o valor por hora?");
double ValorPorHora = double.Parse(Console.ReadLine());

Estacionamento estaciona = new Estacionamento(ValorInicial, ValorPorHora);

Console.Clear();

bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("Digite a Opcao -->\n1 - Cadastrar veiculo\n2 - Remover veiculo\n3 - Listar veiculos\n4 - Encerrar");
    int NumEsco = int.Parse(Console.ReadLine());

    Console.Clear();

    switch (NumEsco)
    {
        case 1:
            estaciona.CadastrarVeiculo();
            break;
        case 2:
            estaciona.RemoverVeiculo();
            break;
        case 3:
            estaciona.MostrarVeiculos();
            break;
        case 4:
            Console.WriteLine("Fim do Programa!");
            exibirMenu = false;
            break;
        default: 
            Console.WriteLine("Opcao invalida");
            break;
    }
}