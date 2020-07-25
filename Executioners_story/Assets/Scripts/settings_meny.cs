using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settings_meny : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider writing_spd;
    public Slider dialog_vol;
    public Slider punc;
    public void writing_speed(float speed)
    {
        PlayerPrefs.SetFloat("writing_speed", speed);
    }
    public void punctation_speed(float speed)
    {
        PlayerPrefs.SetFloat("punctuation_speed", speed);
    }
    public void SetVolume_dialog(float vol)
    {
        PlayerPrefs.SetFloat("vol_dialog", vol);
    }
}
