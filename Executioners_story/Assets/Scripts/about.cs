using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class about : MonoBehaviour
{
  public GameObject menu;
  public GameObject game;
  public GameObject gg;
  public GameObject saydialog_1;
  public GameObject saydialog_2;
  public GameObject menu_vibor;
  public GameObject stage;
  public void About()
  {
    if(PlayerPrefs.GetInt("completes") >= 1)
    {
        menu.SetActive(true);
        game.SetActive(false);
        saydialog_1.SetActive(false);
        saydialog_2.SetActive(false);
        menu_vibor.SetActive(false);
        stage.SetActive(false);
    }
    else
    {
        game.SetActive(false);
        gg.SetActive(true);
        saydialog_1.SetActive(false);
        saydialog_2.SetActive(false);
        menu_vibor.SetActive(false);
        stage.SetActive(false);
    }
  }
}
