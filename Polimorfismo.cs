using UnityEngine;

public class Animal : MonoBehaviour
{
    public virtual void EmitirSonido()
    {
        Debug.Log("El animal emite un sonido.");
    }
}

public class Perro : Animal
{
    public override void EmitirSonido()
    {
        Debug.Log("¡Guau, guau!");
    }
}

public class Gato : Animal
{
    public override void EmitirSonido()
    {
        Debug.Log("¡Miau, miau!");
    }
}