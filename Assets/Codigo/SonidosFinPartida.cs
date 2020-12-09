﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosFinPartida : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip completado;
    public AudioClip gameOver;
    public AudioClip error;
    public void GameOver()
    {
        ReproduceSonido(gameOver);
    }
    public void NivelCompletado()
    {
        ReproduceSonido(completado);
    }
    public void Error()
    {
        ReproduceSonido(error);
    }

    void ReproduceSonido(AudioClip sonido)
    {
        audioSource.clip = sonido;
        audioSource.loop = false;
        audioSource.Play();
    }
}
