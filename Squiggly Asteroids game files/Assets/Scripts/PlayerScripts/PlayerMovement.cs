using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    //movement floats
    public Rigidbody2D rb2d; // referance to the rigidbody attatched to the player sprite
    public float acceleration;
    public float rotationSpeed;
    private float accInput;
    private float rotInput;
    public float screenTop;
    public float screenBottom;
    public float screenLeft;
    public float screenRight;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //checking for input on both axis
        accInput = Input.GetAxis("Vertical");
        rotInput = -Input.GetAxis("Horizontal");

        //screen barriers
        Vector2 newPos = transform.position;
        if(transform.position.y > screenTop)
        {
            newPos.y = screenBottom;
        }
        if(transform.position.y < screenBottom)
        {
            newPos.y = screenTop;
        }
        if(transform.position.x > screenRight)
        {
            newPos.x = screenLeft;
        }
        if(transform.position.x < screenLeft)
        {
            newPos.x = screenRight;
        }
        transform.position = newPos;

    }

    void FixedUpdate()
    {
        //makes sure the ship moves towards the direction its pointing
        rb2d.AddRelativeForce(Vector2.up * accInput);
        rb2d.AddTorque(rotInput);

    }
}
