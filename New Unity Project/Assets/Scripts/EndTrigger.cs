using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform" || collision.gameObject.tag == "Player")
        {
            GameObject gameObject = GameObject.FindGameObjectWithTag("GameManager");
            gameObject.GetComponent<GameManager>().PlayerLost();
        }
        if (collision.gameObject.tag == "Falling Object")
        {
            Destroy(collision.gameObject);
        }
    }
}
