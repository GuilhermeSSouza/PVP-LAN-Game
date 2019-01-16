using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpForce;


    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;
    public KeyCode fire;

    private Rigidbody2D rd2d;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public bool isGrounded;

    // Use this for initialization
    void Start () {
        rd2d = GetComponent<Rigidbody2D>();

		
	}
	
	// Update is called once per frame
	void Update () {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        if (Input.GetKey(left))
        {
            rd2d.velocity = new Vector2(-moveSpeed, rd2d.velocity.y);
        }
        else if (Input.GetKey(right))
        {
            rd2d.velocity = new Vector2(moveSpeed, rd2d.velocity.y);
        }
        else {
            rd2d.velocity = new Vector2(0, rd2d.velocity.y);
            }

        if (Input.GetKeyDown(jump) && isGrounded) {
            rd2d.velocity = new Vector2(rd2d.velocity.x, jumpForce);

        }


    }
}
