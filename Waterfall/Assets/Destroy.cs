using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destroy : MonoBehaviour

{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Ground")
        {
            // destroy this object
            Destroy(collider.gameObject);
        }
    }

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}