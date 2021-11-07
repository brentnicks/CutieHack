using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrush : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Falling Object")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().PlayerLost();
        }
    }
}
