using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int deliveryCount;
    public PlayerMovement carMove;
    public Text counterTxt;
    public GameObject[] packages;
    public GameObject[] delivered;
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        deliveryCount = 0;
    }

    public void CounterUpdate()
    {
        delivered[deliveryCount - 1].SetActive(true);
        counterTxt.text = deliveryCount.ToString();

        if(deliveryCount == packages.Length)
        {
            carMove.turnF = 0;
            carMove.accelerationF = 0;
            gameOver.SetActive(true);
        }
    }

}
