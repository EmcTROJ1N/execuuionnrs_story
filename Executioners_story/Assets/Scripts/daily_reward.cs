using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System;

public class daily_reward : MonoBehaviour
{
    public GameObject reward;
    // Start is called before the first frame update
    void Start()
    {
      if (!PlayerPrefs.HasKey("key_gift"))
      {
      PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
      }
      TimeSpan ts = DateTime.Now - DateTime.Parse(PlayerPrefs.GetString("LastSession"));
      if (ts.Days >= 1)
      {
        reward.SetActive(true);
        int new_key = PlayerPrefs.GetInt("keys");
        new_key += 10;
        PlayerPrefs.SetInt("keys", new_key);
        PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
      }
    }
}
