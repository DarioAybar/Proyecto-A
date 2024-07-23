using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dstruir : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestruirObjeto", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestruirObjeto()
    {
        Destroy(gameObject);
    }
}
