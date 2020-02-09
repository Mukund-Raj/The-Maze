using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Door_Open : MonoBehaviour {
   
    //public GameObject text;
    private Animator DoorAnim;
    public GameObject BrightObject;
    public LensFlare flare;
    public BoxCollider box;
    public TimeCounterForLevel2 time_ref_level2; //reference for time script
    public GameObject handle;
     [HideInInspector] public bool clicked;
    private void Start()
    {
        DoorAnim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {    
      /*  if (other.name == "FPSController" )
        {
            text.SetActive(true);
        }
		*/
        Debug.Log(other.name);
        if (other.gameObject.name == "RigidBodyFPSController")
            handle.SetActive(true);
     
    }
    private void OnTriggerExit(Collider other)
    {
         if(other.gameObject.name== "RigidBodyFPSController")
         {
             handle.SetActive(false);
         }
        Debug.Log(other.name);
      /*  if (other.name == "FPSController")
            text.SetActive(false);*/
    }


    private void Update()
    {
        if (handle.activeSelf)
        {
            if (/*Input.GetKey(KeyCode.E))||*/clicked==true)
            {
                DoorAnim.Play("open");
                //text.SetActive(false);
                handle.SetActive(false);
                box.enabled = false;
                StartCoroutine("End");
            }
        }
    }
    private IEnumerator End()
    {    double time_2;
         yield return new WaitForSeconds(2.7f);
        BrightObject.SetActive(true);
        flare.brightness = 8f;
        yield return new WaitForSeconds(1f);
        time_2 = time_ref_level2.elapsed_time;
        //Debug.Log(time_2);
        PlayerPrefs.SetInt("Level",2);//setting level
        PlayerPrefs.SetInt("Level2Time", (int)time_2);//total time for level 2
        Debug.Log((int)time_2);
        SceneManager.LoadScene("LevelEnd");
    }

}
