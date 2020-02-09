using UnityEngine;

public class AudioStop : MonoBehaviour {

    public AudioSource Current;
    public AudioSource Next;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPSController" || other.name == "RigidBodyFPSController")
        {
            Current.gameObject.SetActive(false);
            Next.gameObject.SetActive(true);
            Next.time = Time.time;
        }
    }
}
