using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -100));
    }
}
