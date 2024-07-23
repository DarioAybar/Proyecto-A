using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAuto : MonoBehaviour
{
    public float velocidad;
    public float rotacion;
    public GameObject proyectil;
    public Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, - rotacion * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotacion * Time.deltaTime , 0);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(proyectil, transform.position + offset, transform.rotation);
        }
    }
}
