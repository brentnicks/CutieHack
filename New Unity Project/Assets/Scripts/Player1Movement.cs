using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public float horizontalSpeed;
<<<<<<< Updated upstream
=======
    bool canJump = true;
    private Vector3 m_Velocity = Vector3.zero;
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        rb = GameObject.Find("Player1").GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 targetVelocity = new Vector2(horizontalSpeed * 10f * Input.GetAxisRaw("Horizontal1"), rb.velocity.y);
        // And then smoothing it out and applying it to the character
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref m_Velocity, 0.05f);

<<<<<<< Updated upstream
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-horizontalSpeed, rb.velocity.y, 0);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
=======

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && canJump)
        {
            rb.AddForce(new Vector2(rb.velocity.x, 500));
            canJump = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
            canJump = true;
    }
>>>>>>> Stashed changes
}
