using UnityEngine;
using UnityEngine.SceneManagement;

public class lastTime : MonoBehaviour {
   // float z;
    public time_script Time_ref;
    private void Start()
    {  
       // z = Time.realtimeSinceStartup;
        // Debug.Log(z);
    }

    private void OnTriggerEnter(Collider other)
    {
        double Actualtime = Time_ref.elapsed_time;
        if (other.gameObject.name == "FPSController"
            || other.gameObject.name== "RigidBodyFPSController")
        {
            //Debug.Log(Actualtime);
            PlayerPrefs.SetInt("Level",1);
            PlayerPrefs.SetInt("Level1Time",(int)Actualtime);
            //total time for level 1
        }

    }

    private void OnTriggerExit(Collider other)
    {    
        SceneManager.LoadScene(sceneName: "LevelEnd");
    }
}
