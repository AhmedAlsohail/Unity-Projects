using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public static AudioClip playerDeathSound, dhabDeathSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        playerDeathSound = Resources.Load<AudioClip>("playerDeath");
        dhabDeathSound = Resources.Load<AudioClip>("dhabDeath");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void playSound (string clip)
    {
        switch (clip)
        {
            case "playerDeath":
                audioSrc.PlayOneShot(playerDeathSound);
                break;
            case "dhabDeath":
                audioSrc.PlayOneShot(dhabDeathSound);
                break;
        }

    }
}
