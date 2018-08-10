using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;
    public int Speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("d"))
        {
            rb.AddForce(Speed, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-Speed, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, Speed);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -Speed);
        }
	}
}
