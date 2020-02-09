using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceClosingEnd : MonoBehaviour {

    public GameObject fenceStart;
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "FPSController" || other.name== "RigidBodyFPSController")
            fenceStart.SetActive(true);
    }
}
