using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codes : MonoBehaviour
{
  public InputField code;
  public GameObject good;
  public void code_check()
  {
    if (code.text == "666")
    {
    if (PlayerPrefs.GetInt("666") == 0)
    {
      int new_keys = PlayerPrefs.GetInt("keys");
      new_keys += 15;
      PlayerPrefs.SetInt("keys", new_keys);
      good.SetActive(true);
      PlayerPrefs.SetInt("666", 1);
    }
  }
    else
    {
      Debug.Log("Такой код уже вводили!");
    }
    if (code.text == "23092005")
    {
    if (PlayerPrefs.GetInt("23092005") == 0)
    {
      int new_keys = PlayerPrefs.GetInt("keys");
      new_keys += 15;
      PlayerPrefs.SetInt("keys", new_keys);
      good.SetActive(true);
      PlayerPrefs.SetInt("23092005", 1);
    }
    else{
      Debug.Log("уже уже уже");
    }
  }
}
}
