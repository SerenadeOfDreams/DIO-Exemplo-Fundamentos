using DIO_Exemplo_Fundamentos.Models;

string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Até breve");
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;

    }
}

Console.WriteLine("O programa se encerrou");




















// Calculadora calc = new();

// calc.Somar(100, 2);
// calc.Subtrair(100, 2);
// calc.Multiplicar(100, 2);
// calc.Dividir(100, 2);
// calc.Potencia(100, 2);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

// calc.RaizQuadrada(9);

// calc.TabuadaFor(10);
// calc.TabuadaWhile(10);
// calc.SomaDoWhile();



// Pessoa p = new("sérgio", 40);

// p.Apresentar();