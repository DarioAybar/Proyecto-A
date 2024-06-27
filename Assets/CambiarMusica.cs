using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarMusica : MonoBehaviour
{
    public AudioSource reproductor;
    public AudioClip musicaFondo;
    public AudioClip musicaCombate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            reproductor.Stop();
            reproductor.clip = musicaCombate;
            reproductor.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            reproductor.Stop();
            reproductor.clip = musicaFondo;
            reproductor.Play();
        }
    }
}
