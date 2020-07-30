using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vibor : MonoBehaviour
{
  public GameObject dialog;
  public GameObject gg;
  void Update()
  {
    if (PlayerPrefs.GetInt("keys") <= 0)
    {
    gg.SetActive(true);
    dialog.SetActive(false);
    }
    else
    {
    gg.SetActive(false);
    dialog.SetActive(true);
    }
  }
  void Start()
  {
    //PlayerPrefs.SetInt("keys", 666);
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
