using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start_gift : MonoBehaviour
{
    public GameObject hi;
    public Slider vol_slider;
    public Slider writing_spd;
    public Slider punc;
    public Slider vol_dialogs;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("vol"))
        {
          PlayerPrefs.SetFloat("vol", 0.5f);
          vol_slider.value = 0.5f;
        }
        if (!PlayerPrefs.HasKey("writing_speed"))
        {
          PlayerPrefs.SetFloat("writing_speed", 60);
          writing_spd.value = 60;
        }
        if (!PlayerPrefs.HasKey("punctation_speed"))
        {
          PlayerPrefs.SetFloat("punctation_speed", 0.25f);
          punc.value = 0.25f;
        }
        if (!PlayerPrefs.HasKey("vol_dialog"))
        {
          PlayerPrefs.SetInt("vol_dialog", 1);
          vol_dialogs.value = 1;
        }
        if (!PlayerPrefs.HasKey("key_gift"))
        {

          Debug.Log("gg");
          hi.SetActive(true);
          int k_gifts = PlayerPrefs.GetInt("k_gifts");
          k_gifts++;
          PlayerPrefs.SetInt("k_gifts", k_gifts);
          int k = PlayerPrefs.GetInt("keys");
          k += 20;
          PlayerPrefs.SetInt("keys", k);
          PlayerPrefs.SetInt("key_gift", 1);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
