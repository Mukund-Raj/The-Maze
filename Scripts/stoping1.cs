using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoping1 : MonoBehaviour
{
    private AudioSource m_audio1;
    public AudioSource m_audio2;

    void Start()
    {
        m_audio1 = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        m_audio1.gameObject.SetActive(false);
        m_audio2.gameObject.SetActive(true);
        Debug.Log(Time.time);
        m_audio2.time = Time.time;
    }
}