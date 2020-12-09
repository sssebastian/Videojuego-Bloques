﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosPelota : MonoBehaviour
{
    public AudioSource rebote;
    public AudioSource punto;

    void OnCollisionEnter(Collision otro)
    {
       if (otro.gameObject.CompareTag("Bloque"))
        {
            punto.Play();

        }
        else
        {
            rebote.Play();
        }
    }


}
