using UnityEngine;

public class Figura : MonoBehaviour
{
    // Este método calculará el área de la figura
    public virtual float CalcularArea()
    {
        return 0f;
    }
}

// Subclase para un rectángulo
public class Rectangulo : Figura
{
    public float baseRectangulo;
    public float alturaRectangulo;

    // Constructor que recibe la base y la altura
    public Rectangulo(float baseRectangulo, float alturaRectangulo)
    {
        this.baseRectangulo = baseRectangulo;
        this.alturaRectangulo = alturaRectangulo;
    }

    // Sobreescribimos el método CalcularArea para el rectángulo
    public override float CalcularArea()
    {
        return baseRectangulo * alturaRectangulo;
    }
}

// Subclase para un cuadrado
public class Cuadrado : Figura
{
    public float lado;

    // Constructor que recibe el lado
    public Cuadrado(float lado)
    {
        this.lado = lado;
    }

    // Sobreescribimos el método CalcularArea para el cuadrado
    public override float CalcularArea()
    {
        return lado * lado;
    }
}

// Subclase para un círculo
public class Circulo : Figura
{
    public float radio;

    // Constructor que recibe el radio
    public Circulo(float radio)
    {
        this.radio = radio;
    }

    // Sobreescribimos el método CalcularArea para el círculo
    public override float CalcularArea()
    {
        return Mathf.PI * radio * radio;
    }
}



// Subclase para un triángulo
public class Triangulo : Figura
{
    public float baseTriangulo;
    public float alturaTriangulo;

    // Constructor que recibe la base y la altura
    public Triangulo(float baseTriangulo, float alturaTriangulo)
    {
        this.baseTriangulo = baseTriangulo;
        this.alturaTriangulo = alturaTriangulo;
    }

    // Sobreescribimos el método CalcularArea para el triángulo
    public override float CalcularArea()
    {
        return 0.5f * baseTriangulo * alturaTriangulo;
    }
}



