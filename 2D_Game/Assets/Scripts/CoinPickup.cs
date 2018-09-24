using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinPickup : MonoBehaviour
{

    public int pointsToAdd;

    void OnTriggerEnter2D(Collider2D theObject)
    {
        if (theObject.name == "PC")
        {
            Debug.Log("touching");

            ScoreManager.AddPoints(pointsToAdd);
            Destroy(gameObject);
        }

    }
}

