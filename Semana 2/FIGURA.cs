using UnityEngine;

public class Figura : MonoBehaviour
{
    public virtual float CalcularArea()
    {
        return 0f;
    }
}

public class Rectangulo : Figura
{
    public float baseRectangulo;
    public float alturaRectangulo;

    public Rectangulo(float baseRectangulo, float alturaRectangulo)
    {
        this.baseRectangulo = baseRectangulo;
        this.alturaRectangulo = alturaRectangulo;
    }

    public override float CalcularArea()
    {
        return baseRectangulo * alturaRectangulo;
    }
}

public class Cuadrado : Figura
{
    public float lado;

    public Cuadrado(float lado)
    {
        this.lado = lado;
    }

    public override float CalcularArea()
    {
        return lado * lado;
    }
}

public class Circulo : Figura
{
    public float radio;

    public Circulo(float radio)
    {
        this.radio = radio;
    }

    public override float CalcularArea()
    {
        return Mathf.PI * radio * radio;
    }
}

public class Triangulo : Figura
{
    public float baseTriangulo;
    public float alturaTriangulo;

    public Triangulo(float baseTriangulo, float alturaTriangulo)
    {
        this.baseTriangulo = baseTriangulo;
        this.alturaTriangulo = alturaTriangulo;
    }

    public override float CalcularArea()
    {
        return 0.5f * baseTriangulo * alturaTriangulo;
    }
}

public class FiguraManager : MonoBehaviour
{
    void Start()
    {
        bool seleccionarNuevaFigura = true;

        while (seleccionarNuevaFigura)
        {
            Debug.Log("Seleccione la figura:");
            Debug.Log("1. Rectángulo");
            Debug.Log("2. Cuadrado");
            Debug.Log("3. Círculo");
            Debug.Log("4. Triángulo");
            Debug.Log("5. Terminar");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Figura rectangulo = new Rectangulo(4f, 6f); 
                    Debug.Log("Área del rectángulo: " + rectangulo.CalcularArea());
                    break;

                case 2:
                    Figura cuadrado = new Cuadrado(5f); 
                    Debug.Log("Área del cuadrado: " + cuadrado.CalcularArea());
                    break;

                case 3:
                    Figura circulo = new Circulo(5f);
                    Debug.Log("Área del círculo: " + circulo.CalcularArea());
                    break;

                case 4:
                    Figura triangulo = new Triangulo(3f, 8f); 
                    Debug.Log("Área del triángulo: " + triangulo.CalcularArea());
                    break;

                case 5:
                    seleccionarNuevaFigura = false;
                    break;

                default:
                    Debug.Log("Opción no válida.");
                    break;
            }

            if (seleccionarNuevaFigura)
            {
                Debug.Log("¿Desea seleccionar otra figura? (Sí/No)");
                string respuesta = Console.ReadLine().Trim().ToLower();

                if (respuesta == "no" || respuesta == "n")
                    seleccionarNuevaFigura = false;
            }
        }
    }
}
