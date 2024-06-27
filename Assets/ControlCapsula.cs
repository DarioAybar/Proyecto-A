using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCapsula : MonoBehaviour
{
    public float velocidad;
    private float xInput;
    private float zInput;
    public GameObject proyectil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ControlJugador();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(proyectil, transform.position, transform.rotation);
        }
    }

    private void ControlJugador()
    {
        xInput = Input.GetAxisRaw("Horizontal") * velocidad * Time.deltaTime;
        zInput = Input.GetAxisRaw("Vertical") * velocidad * Time.deltaTime;
        transform.Translate(xInput, 0, zInput);
        
       
    }
}
