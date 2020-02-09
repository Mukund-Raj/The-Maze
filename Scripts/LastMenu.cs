using UnityEngine.SceneManagement;
using UnityEngine;

public class LastMenu : MonoBehaviour {
    private void Start()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void Quit()
    {     
        SceneManager.LoadScene("Opening Scene"); 
    }
}
