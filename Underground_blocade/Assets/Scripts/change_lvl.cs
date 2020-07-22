using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_lvl : MonoBehaviour
{
    void save_progress()
    {
      int lvl = PlayerPrefs.GetInt("level");
      lvl = 0;
      lvl++;
      Debug.Log(lvl);
      PlayerPrefs.SetInt("level", lvl);
      SceneManager.LoadScene("level" + PlayerPrefs.GetInt("level"));
    }//
}
