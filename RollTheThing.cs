using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollTheThing : MonoBehaviour {

    //private Vector3 rot = new Vector3(0f, 180f, 0f);
    public Transform Thething;
  //  public BoxCollider box;
   // private bool triggered = false;
    private void Start()
    {    
       // Debug.Log(Thething.localEulerAngles.y);
      //  Debug.Log(Thething.eulerAngles.y);
    }
    private void OnTriggerEnter(Collider other)
     {
        Debug.Log(Thething.eulerAngles.y);
        if (other.tag == "Player")
         {
            //triggered = true;
            Thething.rotation = Quaternion.Euler(0f, -Thething.eulerAngles.y, 0f);
         }
        Debug.Log(Thething.eulerAngles.y);
    }
   /* private void OnTriggerExit(Collider other)
    {
        triggered = false;
    }
    private void OnTriggerStay(Collider other)
    {
        
    }*/
    // Update is called once per frame
   /* void Update ()
    {
       // Debug.Log(box.isTrigger);
		if(box.isTrigger==true && triggered==true)
        {
            Thething.rotation = Quaternion.Euler(0f, -Thething.eulerAngles.y, 0f);
            Debug.Log(Thething.eulerAngles.y); 
        }
	}*/
}
