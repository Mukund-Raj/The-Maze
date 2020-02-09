using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FenceSecondClose : MonoBehaviour {

    public GameObject FenceSecond, FenceFirst;
    public TimeScriptForLevelThird T3;//TimeScriptForLevelThird reference
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "RigidBodyFPSController"/*"FPSController"*/&& FenceSecond.activeSelf==false)
            FenceSecond.SetActive(true);
    }

    private void Update()
    {
       // Debug.Log(FenceSecond.activeSelf);
        if(FenceFirst.activeSelf==true && FenceSecond.activeSelf==true)
        {
            StartCoroutine("EndGame");
        }
    }
    private IEnumerator EndGame()
    {   //wait for 9 seconds then level ended
        yield return new WaitForSeconds(9f);
        PlayerPrefs.SetInt("Level", 3); 
        PlayerPrefs.SetInt("Level3Time",(int)T3.elapsed_time);
        SceneManager.LoadScene("LevelEnd");
    }

}
