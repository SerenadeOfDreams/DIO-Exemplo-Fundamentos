namespace DIO_Exemplo_Fundamentos.Models;

public class Calculadora
{
    public void Somar(int x, int y)
    {
        Console.WriteLine($"{x} + {y} = {x + y}");
    }

    public void Subtrair(int x, int y)
    {
        Console.WriteLine($"{x} - {y} = {x - y}");
    }

    public void Multiplicar(int x, int y)
    {
        Console.WriteLine($"{x} x {y} = {x * y}");
    }

    public void Dividir(int x, int y)
    {
        Console.WriteLine($"{x} / {y} = {x / y}");
    }

    public void Potencia(int x, int y)
    {
        var pow = Math.Pow(x, y);
        Console.WriteLine($"{x}^{y} = {pow}");
    }

    public void Seno(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        var seno = Math.Sin(radiano);

        Console.WriteLine($"seno de {angulo}° = {Math.Round(seno, 4)}");
    }

    public void Coseno(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        var cos = Math.Cos(radiano);

        Console.WriteLine($"coseno de {angulo}° = {Math.Round(cos, 4)}");
    }

    public void Tangente(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        var tan = Math.Tan(radiano);

        Console.WriteLine($"tangente de {angulo}° = {Math.Round(tan, 4)}");
    }

    public void RaizQuadrada(double x)
    {
        var raiz = Math.Sqrt(x);

        Console.WriteLine($"Raíz quadrada de {x} = {raiz}");
    }

    public void TabuadaFor(int x)
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{x} x {i} = {x * i}");
        }
    }

    public void TabuadaWhile(int x)
    {
        int i = 1;

        while (i <= 10)
        {
            Console.WriteLine($"{x} x {i} = {x * i}");
            i++;
        }
    }

    public void SomaDoWhile()
    {
        int soma = 0, numero = 0;


        do
        {
            Console.WriteLine("Digite um número (0 para parar.)");
            numero = Convert.ToInt32(Console.ReadLine());

            soma += numero;
        }
        while (numero != 0);

        Console.WriteLine($"Total da soma dos números digitados: {soma}");
    }
}