// Nombre: Ronny Melo
// Fecha: 03-12-2024
// Número de hoja: 1

using System;

public class Circulo
{
    // Propiedad para almacenar el radio del círculo
    private double radio;

    // Constructor para inicializar el radio del círculo
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // CalcularArea es una función que devuelve un valor double,
    // se utiliza para calcular el área de un círculo,
    // requiere como argumento el radio del círculo.
    public double CalcularArea()
    {
        return Math.PI * radio * radio;  // Fórmula para el área: π * radio^2
    }

    // CalcularPerimetro es una función que devuelve un valor double,
    // se utiliza para calcular el perímetro del círculo,
    // requiere como argumento el radio del círculo.
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;  // Fórmula para el perímetro: 2 * π * radio
    }
}

public class Rectangulo
{
    // Propiedades para almacenar la base y la altura del rectángulo
    private double baseRectangulo;
    private double altura;

    // Constructor para inicializar la base y la altura del rectángulo
    public Rectangulo(double baseRectangulo, double altura)
    {
        this.baseRectangulo = baseRectangulo;
        this.altura = altura;
    }

    // CalcularArea es una función que devuelve un valor double,
    // se utiliza para calcular el área de un rectángulo,
    // requiere como argumento la base y la altura del rectángulo.
    public double CalcularArea()
    {
        return baseRectangulo * altura;  // Fórmula para el área: base * altura
    }

    // CalcularPerimetro es una función que devuelve un valor double,
    // se utiliza para calcular el perímetro del rectángulo,
    // requiere como argumento la base y la altura del rectángulo.
    public double CalcularPerimetro()
    {
        return 2 * (baseRectangulo + altura);  // Fórmula para el perímetro: 2 * (base + altura)
    }
}

class Programa
{
    static void Main()
    {
        // Crear una instancia de un círculo con radio 5
        Circulo miCirculo = new Circulo(5);

        // Crear una instancia de un rectángulo con base 4 y altura 6
        Rectangulo miRectangulo = new Rectangulo(4, 6);

        // Calcular y mostrar el área y el perímetro del círculo
        Console.WriteLine("Círculo:");
        Console.WriteLine($"Área del círculo: {miCirculo.CalcularArea()}");
        Console.WriteLine($"Perímetro del círculo: {miCirculo.CalcularPerimetro()}");

        // Calcular y mostrar el área y el perímetro del rectángulo
        Console.WriteLine("\nRectángulo:");
        Console.WriteLine($"Área del rectángulo: {miRectangulo.CalcularArea()}");
        Console.WriteLine($"Perímetro del rectángulo: {miRectangulo.CalcularPerimetro()}");
    }
}
