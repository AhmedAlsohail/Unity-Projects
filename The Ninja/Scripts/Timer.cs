using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float currentime = 0f;
    Text time;
    public Text finalscore;
    // Start is called before the first frame update
    GameObject player;
    void Start()
    {
        time = GetComponent<Text>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            time.text = currentime.ToString("F1") + "s";

            currentime += Time.deltaTime;
        }

        if (player == null)
        {
            finalscore.text = "Final Score: " + currentime.ToString("F1") + "s";
        }

    }
}
