using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start_continue : MonoBehaviour
{
    // Start is called before the first frame update
    public Image nadpis;
    public Sprite start;
    public Sprite cont;
    void Start()
    {
        if (!PlayerPrefs.HasKey("started"))
        {
          nadpis.sprite = start;
        }
        if (PlayerPrefs.HasKey("started"))
        {
          nadpis.sprite = cont;
        }
    }
    public void set_spawn()
    {
      PlayerPrefs.SetInt("started", 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
