using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public GameObject particulas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            Instantiate(particulas, transform.position, transform.rotation);

            Destroy(other.gameObject);
            Destroy(gameObject);


        }


        /*if (other.CompareTag("Enemigo2"))
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
        }*/
    }

  
    void Start()
    {
        Invoke("Destruir", 10f);
    }

    
    void Update()
    {
        transform.Translate(0,0, 14f*Time.deltaTime);
    }

   void Destruir()
    {
        Destroy(this.gameObject);
    }
}
