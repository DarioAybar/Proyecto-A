using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilEnemigo : MonoBehaviour
{
    public float daño;
    public GameObject particulas;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destruirr", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 16f * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(particulas, transform.position, transform.rotation);

            other.GetComponent<VidaPlayer>().vida -= daño;
            Destruirr();
        }
    }

    void Destruirr()
    {
        Destroy(this.gameObject);
    }
}
