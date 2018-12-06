using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour {
    //Player movement variables
    public int MoveSpeed;
    public float JumpHeight;
    public int directon;

    //
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
    private SpriteRenderer mySpriteRenderer;
    private bool doubleJumped;
    public int GetDirection() {
        return directon;
    }

	// Use this for initialization
	void Start () {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
	}

    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }
    // Update is called once per frame
    void Update()
    {
        
        //This code makes the character jump
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {

            Jump();

        }

        if(grounded) {
            doubleJumped = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && !doubleJumped && !grounded) {
            Jump();
            doubleJumped = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            mySpriteRenderer.flipX = true;
            directon = -1;
            GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);

        }
        if (Input.GetKey(KeyCode.D)) {
            mySpriteRenderer.flipX = false;

            directon = 1;
            GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);

        }

        if(Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A)) {
            
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);

            
        }


    }
    public void Jump() {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);

    }
 
}
