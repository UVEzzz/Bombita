using UnityEngine;

public class LanzadorProyectil : MonoBehaviour
{
    public float velocidad = 10f;

    void Start()
    {
        Lanzar(Vector3.forward);
    }

    private void Lanzar(Vector3 direccion)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = direccion * velocidad;
    }
}