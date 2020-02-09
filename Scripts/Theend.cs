using UnityEngine;
//using UnityStandardAssets.Characters.FirstPerson;
public class Theend : MonoBehaviour
{
    public Animator animator;
    public GameObject cu;
    public GameObject cu1;
   // public RigidbodyFirstPersonController rfps;
    public void OnTriggerEnter(Collider other)
    {
        // Debug.Log(other.name);
       // rfps.movementSettings.RunMultiplier = 1.7f;
            animator.Play("the end");
        cu.SetActive(false);
        cu1.SetActive(true);
    }
}