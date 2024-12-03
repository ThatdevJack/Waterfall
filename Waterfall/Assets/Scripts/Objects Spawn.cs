using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class ObjectsSpawn : MonoBehaviour
{
    private Camera mainCamera;
    private float screenWidth;
    private float screenHeight;
    private float objectWidth;


    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        screenHeight = 2F * mainCamera.orthographicSize;
        screenWidth = Screen.height * mainCamera.aspect;
        objectWidth = GetComponent<SpriteRenderer>().bounds.size.y / 3;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

        if (transform.position.y > mainCamera.transform.position.y + screenWidth / 3 + objectWidth)
        {
            newPosition.y = mainCamera.transform.position.y - screenWidth / 3 - objectWidth;
        }
        else if (transform.position.y < mainCamera.transform.position.y - screenWidth / 3 - objectWidth)
        {
            newPosition.y = mainCamera.transform.position.y + screenWidth / 3 + objectWidth;
        }

        transform.position = newPosition;
    }
}
