using UnityEngine;
using UnityEngine.UI;

public class TimeCounterForLevel2 : MonoBehaviour
{
    public Text time_text;
    private int act_time;
    private double t;
    [HideInInspector] public double elapsed_time;

    private void Start()
    {
        elapsed_time = 0f;
        
    }
    private void Update()
    {
        elapsed_time += Time.deltaTime;
        //Debug.Log(elapsed_time);
        act_time = (int)elapsed_time;

        if (act_time <= 60)
            time_text.text = act_time.ToString() + " sec";

        else
        {
            t = act_time / 60f;
            t = System.Math.Round(t, 2);
            time_text.text = t.ToString() + " min";

        }

    }
}