using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {
    public Text timeText;

    private void Start()
    {   Cursor.visible=true;
         double v;
        int t;
        int level = PlayerPrefs.GetInt("Level");
       // Debug.Log(level);
        if (level == 2)
        {
            t = PlayerPrefs.GetInt("Level2Time");
        }
        else if (level == 3)
            t = PlayerPrefs.GetInt("Level3Time");
        else
            t = PlayerPrefs.GetInt("Level1Time");

       // Debug.Log(t);
        
        if(t<=60f)
        {
            v = t;
            timeText.text = v.ToString() + " sec";
        }
        else
        {
            v = t / 60f;
            v = System.Math.Round(v, 2);
            timeText.text = v.ToString() + " min";
        }
    }
}
