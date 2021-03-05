using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storm : MonoBehaviour
{
    public float moveSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(2f, 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }
}
