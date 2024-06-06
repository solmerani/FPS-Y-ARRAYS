using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeScript : MonoBehaviour
{
    public int nivelHambre;

    void TomarAlimento(int valorAlimentario)
    {
        nivelHambre -= valorAlimentario;
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Alimento_Script alimento;
        alimento = other.GetComponent<Alimento_Script>();
        if(alimento)
        {
            TomarAlimento(alimento.valorAlimentario);
        }
    }
}
