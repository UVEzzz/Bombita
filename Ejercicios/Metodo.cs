using UnityEngine;

public class Cuadrado : MonoBehaviour
{
    public float lado;

    public float CalcularAreaCuadrado()
    {
        return lado * lado;
    }
}

public class Circulo : MonoBehaviour
{
    public float radio;

    public float CalcularAreaCirculo()
    {
        return Mathf.PI * radio * radio;
    }
}

void Start()
{
    Cuadrado cuadrado = new Cuadrado();
    cuadrado.lado = 5f;

    Circulo circulo = new Circulo();
    circulo.radio = 3f;

    Debug.Log("Área del cuadrado: " + cuadrado.CalcularAreaCuadrado());
    Debug.Log("Área del círculo: " + circulo.CalcularAreaCirculo());
}