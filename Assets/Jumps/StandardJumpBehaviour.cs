using UnityEngine;
using System.Collections;
using Assets;
using System;

public class StandardJumpBehaviour : JumpBehaviour {

    private float _jumpSpeed = 6.0f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
	}

    private Rigidbody2D rb
    {
        get { return GetComponent<Rigidbody2D>(); }
    }

    private Vector2 velocity
    {
        get { return rb.velocity; }
        set { rb.velocity = value; }
    }
    
    protected override void PerformJump()
    {
        rb.velocity += new Vector2(0, _jumpSpeed);
    }
}
