using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class menu_volume : MonoBehaviour
{
  public Slider volume_music;
  public Slider volume_dialog;
  public Slider writing_spd;
  public Slider punc;
  public WriterAudio volume_dialog_script;
  public Writer saydialog_script;
    // Start is called before the first frame update
    void Start()
    {
      volume_music.value = PlayerPrefs.GetFloat("vol");

      volume_dialog.value =PlayerPrefs.GetFloat("vol_dialog");
      volume_dialog_script.volume = PlayerPrefs.GetFloat("vol_dialog");

      saydialog_script.writingSpeed = PlayerPrefs.GetFloat("writing_speed");
      writing_spd.value = PlayerPrefs.GetFloat("writing_speed");

      punc.value = PlayerPrefs.GetFloat("punctation_speed");
      saydialog_script.punctuationPause = PlayerPrefs.GetFloat("punctation_speed");
    }
}
