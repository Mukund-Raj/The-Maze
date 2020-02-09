using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Pausescript :MonoBehaviour {
    //public GameObject pause;
	private Toggle pausemenu;
    private bool IsPaused = false;
  //  public GameObject fps;
    public GameObject resolution;
    

    private void Start()
    {
      //  Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
        Time.timeScale = 1f;
		pausemenu = GetComponent<Toggle>();
    }

    // Update is called once per frame
    private void Update ()
    {
        
		if(Input.GetKeyUp(KeyCode.Escape))
        {
			pausemenu.isOn = !pausemenu.isOn;
			//IsPaused = pausemenu.isOn;

            //Debug.Log("key is pressed");
            /*if (!IsPaused)
            {
                Pause();
            }*/
        }

	}
      void Resume()
    {
        //pause.SetActive(false);
        IsPaused = false;
        Time.timeScale = 1f;                      
    }

    void Pause()
    {
       // Cursor.lockState = CursorLockMode.None;
       // Cursor.visible = true;
        //pause.SetActive(true);
        IsPaused = true;
        Time.timeScale = 0f;
      //  fps.GetComponent<FirstPersonController>().enabled = false;
       
       
     }
	public void onMenuStatusChange()
	{
		if(pausemenu.isOn && !IsPaused)
		{
			Pause();
		}

		else if(!pausemenu.isOn && IsPaused)
		{
			Resume();
		}
	}
    public void Quit()
    {
        Application.Quit();

    }
    public void MenuClick()
    {
         SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void RestartLevel()
    {  
        int z = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(z);
        Time.timeScale = 1f;
        //IsPaused = false;
    }
    public void ClickResume()
    {
        //pause.SetActive(false);
       // Cursor.lockState = CursorLockMode.Locked;
       // Cursor.visible = false;
        IsPaused = false;
        Time.timeScale = 1f;
		pausemenu.isOn = !pausemenu.isOn;
	  //  fps.GetComponent<FirstPersonController>().enabled =true;

	}
   public void ResolutionClick()
    {
        if (resolution.activeSelf == false)
            resolution.SetActive(true);
        else
            resolution.SetActive(false);
    }
    public void Good()
    {
        QualitySettings.SetQualityLevel(3, true);
        resolution.SetActive(false);
    }
    public void Beautiful()
    {
        QualitySettings.SetQualityLevel(4, true);
        resolution.SetActive(false);
    }
    public void Fantastic()
    {
        QualitySettings.SetQualityLevel(5, true);
        resolution.SetActive(false);
    }
    
}
