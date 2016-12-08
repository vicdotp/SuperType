using UnityEngine;
using System.Collections;
using Assets;
using System;

public class StandardRunBehaviour : RunBehaviour {
    private float _runSpeed = 2.0f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //if(Input.GetAccelerationEvent)
        Run();
        
        //Debug.Log(string.Format("Velocidade: {0},{1}", velocity.x, velocity.y));
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
    
    protected override void PerformRun()
    {
        if (velocity.x == 0)
            velocity += new Vector2(_runSpeed, 0);
    }
}
