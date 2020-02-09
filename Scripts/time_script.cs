using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class time_script : MonoBehaviour {
    public Text time_text;
    private int act_time;
    private double t;
    private string scene;
    [HideInInspector] public double elapsed_time;//total elapsed time
    private void Start()
    {
        scene = SceneManager.GetActiveScene().name;

        if (scene == "First_Level_Restart")
        {
            elapsed_time = PlayerPrefs.GetInt("timevalue") - 3;
        }
        else
        {
            elapsed_time = 0f;
            PlayerPrefs.SetInt("Count", 0);
        }
    }
    
    void Update ()
    {
        elapsed_time += Time.deltaTime;
        //Debug.Log(elapsed_time);
        act_time = (int)elapsed_time;

        if (act_time<=60)
            time_text.text = act_time.ToString() + " sec";

        else
        {
            t = act_time / 60f;
            t = System.Math.Round(t, 2);
            time_text.text =t.ToString() + " min";

        }

        PlayerPrefs.SetInt("timevalue", act_time);
    }
}
