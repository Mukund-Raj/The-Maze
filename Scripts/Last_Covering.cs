using UnityEngine;
//using UnityStandardAssets.Characters.FirstPerson;
public class Last_Covering : MonoBehaviour
{
    public Animator last;
    //public RigidbodyFirstPersonController rps;
    //public Toggle runbutton;

    private void OnTriggerEnter(Collider other)
    {
       // Debug.Log(other.name);
        if (other.name == "FPSController" || other.name == "RigidBodyFPSController")
        {
             // Debug.Log(other.name);
            // runbutton.isOn = false;
            last.Play("last cover");
        }
    }

}