using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraScript : MonoBehaviour

{
    public Transform xaxislock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerposition = new Vector3(0, xaxislock.position.y, -6.327286f);
        gameObject.transform.position = playerposition;
    }
}
