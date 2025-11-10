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
}