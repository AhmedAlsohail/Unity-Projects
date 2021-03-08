using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float currentime = 0f;
    Text time;
    // Start is called before the first frame update
    void Start()
    {
        time = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time.text = currentime +"s";

        currentime += Time.deltaTime;
    }
}
