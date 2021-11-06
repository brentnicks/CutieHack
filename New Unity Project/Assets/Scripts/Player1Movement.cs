using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public float horizontalSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GameObject.Find("Player1").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(horizontalSpeed, rb.velocity.y, 0);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-horizontalSpeed, rb.velocity.y, 0);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
