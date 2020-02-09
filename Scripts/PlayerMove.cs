using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	private float h;
	private float v;
	public float xsen=1f;
	public float zsen=0.7f;
	public float movespeed = 1f;
	private Rigidbody rb;
	void Start () 
	{  rb = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{   
		h = Input.GetAxis ("Horizontal")*xsen;
		v = Input.GetAxis ("Vertical")*zsen;

		Vector3 move = new Vector3 (h, 0.0f, v);
		rb.AddForce (move * movespeed);
		
	}
}
