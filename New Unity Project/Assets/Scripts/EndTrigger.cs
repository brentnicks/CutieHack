using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
     private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject gameObject = GameObject.FindGameObjectWithTag("GameManager");
        gameObject.GetComponent<GameManager>().PlayerLost();
        Debug.Log("You Lose.");
    }
}
