using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {


	public GameObject Replace;
	void OnCollisionEnter()
	{   
		
		GameObject.Instantiate (Replace, transform.position, transform.rotation);
		Destroy (gameObject);
	}
}