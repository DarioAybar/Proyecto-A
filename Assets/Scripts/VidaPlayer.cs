using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{
    public float vida = 100;
    public float vidaMaxima = 150;

    public Image barraDeVida;

    private void Start()
    {
        vida = vidaMaxima;
    }


    void Update()
    {
        //vida = Mathf.Clamp(vida, 0, 100);

        barraDeVida.fillAmount = vida / vidaMaxima;

        if(vida <= 0)
        {
            gameObject.SetActive(false);
        }
    }


}
