using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Packages : MonoBehaviour
{
    public GameObject carPack;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (carPack.activeSelf == false)
        {
            carPack.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
