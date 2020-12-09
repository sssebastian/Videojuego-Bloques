using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidadInicial = 600f;

    public Rigidbody rig;

    bool enJuego;

    Vector3 posicionInicial;

    public Transform barra;

    public ElementoInteractivo pantalla;

    void Start()
    {
        posicionInicial = transform.position;
    }
    public void Reset()
    {
        transform.position = posicionInicial;
        transform.SetParent(barra);
        enJuego = false;
        DetenerMovimiento();
    }

    public void DetenerMovimiento()
    {
        rig.isKinematic = true;
        rig.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (!enJuego && Input.GetButtonDown("Fire1") || pantalla.pulsado)
        {
            enJuego = true;
            transform.SetParent(null);
            rig.isKinematic = false;
            rig.AddForce(new Vector3(velocidadInicial, velocidadInicial, 0));
        }
    }
}
