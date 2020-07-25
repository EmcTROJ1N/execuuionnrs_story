using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class writing_saydialog : MonoBehaviour
{
    public Writer script;
    public Slider punc;
    public Slider speed_wr;
    // Start is called before the first frame update
    void Start()
    {
      punc.value = PlayerPrefs.GetFloat("punctuation_speed");
      speed_wr.value = PlayerPrefs.GetFloat("writing_speed");
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void writing_speed(float speed)
    {
        script.writingSpeed = speed;
        PlayerPrefs.SetFloat("writing_speed", speed);
    }
    public void punctation_speed(float speed)
    {
        script.punctuationPause = speed;
        PlayerPrefs.SetFloat("punctuation_speed", speed);
    }
}
