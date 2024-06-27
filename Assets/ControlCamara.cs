using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    //public GameObject Camara;
    public Vector3 compensacion;
    public GameObject CamaraAuto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = CamaraAuto.transform.position + compensacion;
    }
}
