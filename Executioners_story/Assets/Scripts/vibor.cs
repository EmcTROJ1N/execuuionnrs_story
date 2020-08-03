using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class vibor : MonoBehaviour
{
  public GameObject dialog;
  public GameObject gg;
  public DialogInput script;
  void Update()
  {
    if (PlayerPrefs.GetInt("keys") <= 0)
    {
    gg.SetActive(true);
    dialog.SetActive(false);
    script.enabled = false;
    }
    else
    {
    gg.SetActive(false);
    dialog.SetActive(true);
    script.enabled = true;
    }
  }
  void Start()
  {
    //PlayerPrefs.SetInt("keys", 0);
  }
  public void plus20()
  {
    int new_keys = PlayerPrefs.GetInt("keys");
    new_keys += 20;
    PlayerPrefs.SetInt("keys", new_keys);
  }
  public void minus()
  {
    if (!PlayerPrefs.HasKey("premium"))
    {
    int new_keys = PlayerPrefs.GetInt("keys");
    new_keys -= 2;
    PlayerPrefs.SetInt("keys", new_keys);
    }
  }
  public void gg_vp()
  {
    gg.SetActive(true);
  }
}
