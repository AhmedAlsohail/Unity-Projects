using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dhab : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            gameObject.SetActive(false);
            soundManager.playSound("dhabDeath");
            Score.scoreValue += 5;
        }

        if (col.gameObject.tag.Equals("lavafloor"))
        {
            gameObject.SetActive(false);
        }
    }

}
