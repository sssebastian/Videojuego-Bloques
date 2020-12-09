using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiguienteNivel : MonoBehaviour
{

    public string nivelACargar;
    public float retraso;
    // Start is called before the first frame update

    [ContextMenu("Activar Carga")]
    public void ActivarCarga()
    {
        Invoke("CargarNivel", retraso);
    }

    void CargarNivel()
    {
        if(!EsUltimoNivel())
        {
            Vidas.vidas++;
        }

        Application.LoadLevel(nivelACargar);
    }

    public bool EsUltimoNivel()
    {
      
            return nivelACargar == "Portada";
        
    }
}
