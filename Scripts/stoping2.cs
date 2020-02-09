using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoping2 : MonoBehaviour
{

    private AudioSource m_audio2;
    
    void Start()
    {
        m_audio2 = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
       
        //Debug.Log(other.name);
        m_audio2.volume = 0.1f;
       
    }
}