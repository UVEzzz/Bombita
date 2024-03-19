using UnityEngine;

public class Personaje : MonoBehaviour
{
    public string nombre;
    public int salud;
    
    public virtual void Saludar()
    {
        Debug.Log("¡Hola! Mi nombre es " + nombre);
    }
}

public class Jugador : Personaje
{
    public int nivel;
    
    public void SubirNivel()
    {
        nivel++;
    }
    
    public override void Saludar()
    {
        Debug.Log("¡Hola! Soy " + nombre + ", el jugador de nivel " + nivel);
    }
}