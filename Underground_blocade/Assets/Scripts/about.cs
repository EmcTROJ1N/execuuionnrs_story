using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class about : MonoBehaviour
{
  public GameObject menu;
  public GameObject game;
  public GameObject gg;
  public GameObject saydialog;
  public GameObject menu_vibor;
  public void About()
  {
    if(PlayerPrefs.GetInt("completes") >= 1)
    {
        menu.SetActive(true);
        game.SetActive(false);
        saydialog.SetActive(false);
        menu_vibor.SetActive(false);
    }
    else
    {
        game.SetActive(false);
        gg.SetActive(true);
        saydialog.SetActive(false);
        menu_vibor.SetActive(false);
    }
  }
}
