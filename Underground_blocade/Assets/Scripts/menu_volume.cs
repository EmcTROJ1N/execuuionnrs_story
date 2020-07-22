using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu_volume : MonoBehaviour
{
  public Slider volume;
    // Start is called before the first frame update
    void Start()
    {
      volume.value = PlayerPrefs.GetFloat("vol");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
