using UnityEngine;

public class Constructor : MonoBehaviour
{
    
    public GameObject objetoPrefab;
    public Vector3 posicionInicial;
    
    public void ConstruirObjeto()
    {
        Instantiate(objetoPrefab, posicionInicial, Quaternion.identity);
    }
    
    public void DestruirObjeto(GameObject objeto)
    {
        Destroy(objeto);
    }
}