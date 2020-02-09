using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftAndRightCheck : MonoBehaviour {

    public AudioSource source;
    public GameObject check;
    public GameObject AudioOb;
    private void Start()
    {
        AudioOb.SetActive(true);
        source = source.GetComponent<AudioSource>();
    }
    private void Update()
    {
       // Debug.Log("working");
        if (AudioOb.activeSelf == false)
            AudioOb.SetActive(true);
        source.panStereo = -1;
        //StartCoroutine("PlayAudio");
    }
    /*
    private IEnumerator PlayAudio()
    {
        Debug.Log("coroutine work");
        source.panStereo = -1;
        source.Play();
        yield return new WaitForSeconds(6f);
        source.panStereo = 1;
        source.Play();
    }
    */

    public void OK()
    {
        check.SetActive(false);
        AudioOb.SetActive(false);
    }
}
