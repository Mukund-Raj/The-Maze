using UnityEngine;
using UnityEngine.UI;

public class statsInfo : MonoBehaviour {
    public Text level1Time;
    public Text level2time;
    public Text level3time;
    private void Start()
    {
        int l1 = PlayerPrefs.GetInt("Level1Time");
        int l2 = PlayerPrefs.GetInt("Level2Time");
        int l3= PlayerPrefs.GetInt("Level3Time");

        level1Time.text = "Level 1 : " + System.Math.Round((l1/60f),2).ToString()+" min";
        level2time.text = "Level 2 : " + System.Math.Round((l2/60f),2).ToString()+" min";
        level3time.text = "Level 3 : " + System.Math.Round((l3/60f),2).ToString()+" min";
    }

}
