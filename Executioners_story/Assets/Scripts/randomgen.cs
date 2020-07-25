using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class randomgen : MonoBehaviour
{
    public Text text_rew;
    public string[] arr = {
      "Салам алейкум, {username}, держи подарок и вперед!",
    };
    // Start is called before the first frame update
    void Start()
    {
      System.Random rnd = new System.Random();
      int k = rnd.Next(0, arr.Length);
      text_rew.text = arr[k];
    }

    // Update is called once per frame
    void Update()
    {

    }
}
