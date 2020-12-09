using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour
{
    public float velocidad = 0.4f;

    Vector3 posicionInicial;

    public ElementoInteractivo botonizquierdo;
    public ElementoInteractivo botonderecho;


    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
    }

    public void Reset()
    {
        transform.position = posicionInicial;
    }
    // Update is called once per frame
    void Update()
    {
        float direccion;
        if (botonizquierdo.pulsado)
        {
            direccion = -1;
        }else if (botonderecho.pulsado)
        {
            direccion = 1;
        }
        else
        {
            direccion = Input.GetAxisRaw("Horizontal");
        }
        float posX = transform.position.x + (direccion * velocidad * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(posX, -8, 8 ), transform.position.y, transform.position.z);
    }
}
