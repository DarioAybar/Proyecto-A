using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilEnemigo : MonoBehaviour
{
    public float daño;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destruirr", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 8 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<VidaPlayer>().vida -= daño;
        }
    }

    void Destruirr()
    {
        Destroy(this.gameObject);
    }
}
