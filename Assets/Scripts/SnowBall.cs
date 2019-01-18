using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour {


    public float ballspeed;
    public GameObject snowBallEfect;




    private Rigidbody2D rg2d;
    

	// Use this for initialization
	void Start () {
        rg2d = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
        rg2d.velocity = new Vector2(ballspeed*transform.localScale.x, 0);
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player_1") {
            FindObjectOfType<GameManager>().HurtP1();
        }

        if (collision.tag == "Player_2")
        {
            FindObjectOfType<GameManager>().HurtP2();
        }
        


        Instantiate(snowBallEfect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
