using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnscript : MonoBehaviour {

    public Animator anim;

    /*private void Start()
    {
        anim = GetComponent<Animator>();
    */

    private void OnTriggerEnter(Collider other)
    {
       // Debug.Log("it works");
        anim.Play("cube move");
    }

    /*private void OnTriggerExit(Collider other)
    {
        anim.SetTrigger("turns");
        anim.gameObject.SetActive(false);

    }*/


}
