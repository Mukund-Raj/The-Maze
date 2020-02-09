using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Mve : MonoBehaviour {
     
	private Quaternion current;
	public Transform cam;
	void Start()
	{  
		current = cam.transform.rotation;
		
	}
	// Update is called once per frame
	void Update () {

		cam.transform.rotation = current;

	}
}
