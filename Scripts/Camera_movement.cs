using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_movement : MonoBehaviour {
	public float cameraspeed=150f;
	public GameObject camerafollowobj;
	Vector3 followobj;
	public float clampangle=70f;
	public float inputsensitivity=5f;
	public GameObject cameraobj;
	public GameObject playerobj;
	public float cameradistancextoplayer;
	public float cameradistanceytoplayer;
	public float cameradistanceztoplayer;
	private float mousex;
	private float mousey;
	public float finalinputx;
	public float finalinputz;
	public float smoothx=3f;
	public float smoothy=3f;
	private float rotx=0.0f;
	private float roty=0.0f;


	void Start()
	{
		Vector3 rot = transform.localRotation.eulerAngles;
		roty = rot.y;
		rotx = rot.x;
		//Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;
	}

	void Update()
	{    mousex = Input.GetAxis ("Mouse X");
		 mousey = Input.GetAxis ("Mouse Y");
		roty += mousex * inputsensitivity * Time.deltaTime;
		rotx += mousey * inputsensitivity * Time.deltaTime;

		rotx = Mathf.Clamp (rotx, -clampangle, clampangle);
		Quaternion localrotation = Quaternion.Euler (rotx, roty, 0);
		transform.rotation = localrotation;
		
	}
	void LateUpdate()
	{  cameraupdater ();
	
	}

	void cameraupdater()
	{  Transform target = camerafollowobj.transform;

		float step = cameraspeed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target.position, step);
	}
}


