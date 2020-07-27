using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

public class ui : MonoBehaviour
{
  public Text deads;
  public Text completes;
  public Text keys;
  public Image bg;
  public Sprite new_bg;
  public Sprite good_bg;
  public GameObject posle;

  void Update()
  {
    key();
  }
  public void posleslovie()
  {
    posle.SetActive(true);
  }
  public void key()
  {
      keys.text = PlayerPrefs.GetInt("keys").ToString();
      if (Int32.Parse(keys.text) <= 2)
      {
        bg.sprite = new_bg;
      }
      if (Int32.Parse(keys.text) >= 2)
      {
        bg.sprite = good_bg;
      }
  }
  public void statistic()
  {
      deads.text =  "Смертей: " + PlayerPrefs.GetInt("deads");
      completes.text =  "Прохождений: " + PlayerPrefs.GetInt("completes");
      Debug.Log(PlayerPrefs.GetInt("deads"));
  }
  public void comp()
  {
    int complet = PlayerPrefs.GetInt("completes");
    complet += 1;
    PlayerPrefs.SetInt("completes", complet);
  }
  public void dead()
  {
    int deds = PlayerPrefs.GetInt("deads");
    deds += 1;
    PlayerPrefs.SetInt("deads", deds);
  }
  public void PlayPressed()
      {
          PlayerPrefs.SetInt("level", 0);
          SceneManager.LoadScene("level0");
      }
  public void ComePressed()
      {
          SceneManager.LoadScene("Menu");
      }

  public void ExitPressed()
      {
          Application.Quit();
          Debug.Log("Exit pressed!");
      }
  public void OpenUrl(string url)
  {
    Application.OpenURL(url);
  }
}
