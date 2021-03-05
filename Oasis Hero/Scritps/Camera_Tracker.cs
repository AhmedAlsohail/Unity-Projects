using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Tracker : MonoBehaviour
{
    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //we store current camera's position on a variable temp
        Vector3 temp = transform.position;

        //we set the camera's position x to be equal to the player's position x
        temp.x = playerTransform.position.x;

        //we set the camera's position x to be equal to the player's position x
        temp.y = playerTransform.position.y + 3;

        //we set back the temp's position the to camera's position 
        transform.position = temp;

    }
}
