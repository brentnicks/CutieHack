using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPhysics : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Falling Object")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(100,100));
        }
    }
}
