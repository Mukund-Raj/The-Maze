using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class shrink : MonoBehaviour
{
    public GameObject die;
    public Transform left, right;
    private float distance;
    private bool IsReached = false;
    private WaitForSeconds Wait = new WaitForSeconds(3f);
   // public GameObject player;
    // public Transform respawn_point;
    //  private float timec;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name=="FPSController"|| other.name== "RigidBodyFPSController")
        {
            IsReached = true;
        }
    }


    private void Update()
    {
       
        distance = left.transform.localPosition.x + right.transform.localPosition.x;
        //Debug.Log(distance);

        if(distance>=0.5000f && IsReached==false)
        {
            Time.timeScale = 0f;
            die.SetActive(true);
            StartCoroutine("Myplayer");
        }
                         
    }
    private IEnumerator Myplayer()
    {
        Time.timeScale = 1f;
        //Debug.Log(Time.timeScale);
        yield return Wait;
        die.SetActive(false);
        SceneManager.LoadScene("First_Level_Restart");
    }
}
