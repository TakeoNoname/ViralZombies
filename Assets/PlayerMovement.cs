using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float MoveSpeed = 10f;
    public float jumpForce = 5f;

    public Rigidbody2D playerRB;

    public bool isGrounded = false;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float X = Input.GetAxisRaw("Horizontal");

        playerRB.velocity = new Vector2(X * MoveSpeed, playerRB.velocity.y);


        if (X <= -0.1)
        {
            gameObject.transform.eulerAngles = new Vector3(0,180,0);
        }
        if (X >= 0.1)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.Space) && isGrounded == true)
        {
            playerRB.AddForce(Vector2.up * jumpForce);
            isGrounded = false;
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }
}
