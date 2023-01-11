using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    public float currentTime =90;
    public PlayerMovement carMove;
    public Text timerTxt;
    public GameObject gameOver;
    public GameManager manager;

    private void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
        }

        else
        {
            currentTime = 0;
            carMove.turnF = 0;
            carMove.accelerationF = 0;
        }

        DisplayTime(currentTime);
    }
    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
            if (manager.deliveryCount !=6)
            {
                gameOver.SetActive(true);
            }
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
