using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Type : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Falling Object")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        }
    }
}
