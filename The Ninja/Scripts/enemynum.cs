using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemynum : MonoBehaviour
{
    public GameObject gameOverText, restartButton;
    public static int currentnum = 0;
    Text Score;
    // Start is called before the first frame update
    void Start()
    {
        currentnum = 0;
        Timer.currentime = 0;

        gameOverText.SetActive(false);
        restartButton.SetActive(false);
        Score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = currentnum + " Enemies are alive";

        if(currentnum >= 5)
        {
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            gameObject.SetActive(false);

         
        }
    }

    
}
