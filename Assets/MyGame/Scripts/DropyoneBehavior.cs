using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropyoneBehavior : MonoBehaviour
{
    public GameObject carPack;
    public GameManager manager;

    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (carPack.activeSelf == true)
        {
            carPack.SetActive(false);
            manager.deliveryCount++;
            manager.CounterUpdate();
            Debug.Log(manager.deliveryCount);
        }
    }
}
