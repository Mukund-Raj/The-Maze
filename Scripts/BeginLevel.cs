using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BeginLevel : MonoBehaviour
{
    public void Ok_i_got_it()
    {
        SceneManager.LoadScene("Third_Level");
    }

}
