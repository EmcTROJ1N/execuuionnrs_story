using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class statistic : MonoBehaviour
{
    public Text deads;
    public Text completes;
    public Text add;
    public Text gifts;
    // Start is called before the first frame update
    public void stata()
    {
        Debug.Log("gg");
        deads.text =  "Смертей: " + PlayerPrefs.GetInt("deads");
        completes.text = "Прохождений: " + PlayerPrefs.GetInt("completes");
        add.text = "Рекламы просмотрено: " + PlayerPrefs.GetInt("adds");
        gifts.text = "Бонусов получено: " + PlayerPrefs.GetInt("k_gifts");
    }
}
