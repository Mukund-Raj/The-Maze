using UnityEngine;

public class UiScript : MonoBehaviour {
	public GameObject text;
	void Start () 
	{
        text.SetActive (false);		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            Showtext();
           // Debug.Log("It work");         
        }
    }
        public void Showtext()
        {
        text.SetActive(true);
        }


	
}
