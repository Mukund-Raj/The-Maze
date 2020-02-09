using UnityEngine;

public class EndLevelmoving: MonoBehaviour {

    public Animator anim;
   private float CurrentTime;
    public BoxCollider box;
    private void Start()
    {
        enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {   
       
            CurrentTime = Time.time;
            anim.Play("last level Animation");
             enabled = true;
        
    }
       private void Update()
    {
           // Debug.Log(Time.time);
            if(Time.time >=(CurrentTime+5f))
                box.gameObject.SetActive(false);
                
           
        
    }

}
