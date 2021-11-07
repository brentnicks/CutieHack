using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public float horizontalSpeed;
    bool canJump = true;
    private Vector3 m_Velocity = Vector3.zero;
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


        if (Input.GetKeyDown(KeyCode.W) && canJump)
        {
            rb.AddForce(new Vector2(rb.velocity.x, 500));
            canJump = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            canJump = true;
        }
    }
}
