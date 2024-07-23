using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TanqueEnemigo : MonoBehaviour
{
    public GameObject proyectil;
    public Vector3 offset;

    private float timer;
    private float timerDisparo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        timerDisparo += Time.deltaTime;

        if(timerDisparo > 1.5f)
        {
            Instantiate(proyectil, transform.position + offset, transform.rotation);
            timerDisparo = 0f;
        }

        if(timer > 8f)
        {
            transform.Rotate(0, 90, 0);
            timer = 0;
        }

        transform.Translate(0, 0, 5 * Time.deltaTime);    
    }
}
