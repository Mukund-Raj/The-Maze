using UnityEngine;
using UnityEngine.UI;

public class Timescript : MonoBehaviour {
    float z,z1;
    public Text TimeText;
    private void Start()
    {
        
        z = Time.realtimeSinceStartup;
        //Debug.Log(z);
    }
    
    private void OnTriggerEnter(Collider other)
    {
       float Actualtime = Time.time - z;
        if(other.gameObject.name=="FPSController")
        {
            Debug.Log("Time:" + Actualtime);
            //TimeText.text = "TIME:"+Actualtime.ToString();
        }
    }

    private void Update()
    {
        z1 = Time.time;
        TimeText.text = "TIME:" +z1.ToString();
    }


}
