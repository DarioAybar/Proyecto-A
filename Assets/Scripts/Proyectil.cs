using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Enemigo2"))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Enemigo3"))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Enemigo4"))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Enemigo5"))
        {
            Destroy(other.gameObject);
        }
    }

  
    void Start()
    {
        Invoke("Destruir", 10f);
    }

    
    void Update()
    {
        transform.Translate(0,0, 8*Time.deltaTime);
    }

   void Destruir()
    {
        Destroy(this.gameObject);
    }
}
