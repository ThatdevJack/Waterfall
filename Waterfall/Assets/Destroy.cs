using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destroy : MonoBehaviour

{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "GameObject")
        {
            Destroy(collision.gameObject);
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