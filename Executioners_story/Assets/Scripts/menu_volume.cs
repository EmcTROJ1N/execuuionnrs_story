using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class menu_volume : MonoBehaviour
{
  public Slider volume_music;
  public Slider volume_dialog;
  public WriterAudio volume_dialog_script;
    // Start is called before the first frame update
    void Start()
    {
      volume_music.value = PlayerPrefs.GetFloat("vol");
      volume_dialog.value =PlayerPrefs.GetFloat("vol_dialog");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
