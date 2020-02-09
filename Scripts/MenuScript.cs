using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public GameObject menu;
    public GameObject stats;
    public GameObject check;
    
    public void ClickLevel1()
    {
        SceneManager.LoadScene("First_Level");
        Time.timeScale = 1f;
    }
    public void ClickLevel2()
    {
        SceneManager.LoadScene("Second_Level");
        Time.timeScale = 1f;  
    }
    public void ClickLevel3()
    {
        SceneManager.LoadScene("Third_Level");
        Time.timeScale = 1f;
    }

    public void ClickQuit()
    {
        Application.Quit();
    }
    public void StatsClick()
    {
       if(stats.activeSelf==false)
           stats.SetActive(true);
        else
            stats.SetActive(false);
    }
    public void ClickCheck()
    {
        check.SetActive(true);
    }
}

