using UnityEngine;

public class stoping : MonoBehaviour {

    private AudioSource m_audio;
    public AudioSource m_audio1;
    public TimeScriptForLevelThird tRef;
    void Start () {
        m_audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        m_audio.gameObject.SetActive(false);
        m_audio1.gameObject.SetActive(true);
        m_audio1.time = (float)tRef.elapsed_time;
       // Debug.Log("Time" + Time.time);
    }


}
