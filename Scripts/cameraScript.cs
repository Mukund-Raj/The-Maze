using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {
	public Animator anim;
	public Transform tolookat;
	private float h;
	private float v;

	void Start () 
	{
		anim =GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{   h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis ("Vertical");
	}

	void FixedUpdate()
	{
		anim.SetFloat ("inputz", v);
		anim.SetFloat ("inputx", h);
		 
		 if (v > 0.2f && transform.rotation != tolookat.transform.localRotation)
		{  Quaternion turnAngle = Quaternion.Euler (0, tolookat.eulerAngles.y, 0);
			transform.rotation = turnAngle;	
		 }
	}
}
