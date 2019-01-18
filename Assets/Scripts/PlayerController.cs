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


    public GameObject snowBall;
    public Transform throwPoint;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public bool isGrounded;
    public AudioSource pThrow;



    private Rigidbody2D rd2d;
    private Animator anim;


    // Use this for initialization
    void Start () {
        rd2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
		
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

        if (Input.GetKeyDown(fire)){ 
            GameObject ballCall =  (GameObject) Instantiate(snowBall, throwPoint.position, throwPoint.rotation);
            ballCall.transform.localScale = transform.localScale;
            anim.SetTrigger("Throw");
            pThrow.Play();
        }

        if (rd2d.velocity.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (rd2d.velocity.x > 0) {

            transform.localScale = new Vector3(1, 1, 1);
        }


        anim.SetFloat("Speed", Mathf.Abs(rd2d.velocity.x));
        anim.SetBool("Grounded", isGrounded);


    }
}
