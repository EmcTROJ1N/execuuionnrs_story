using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_gift : MonoBehaviour
{
    public GameObject hi;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("vol"))
        {
          PlayerPrefs.SetFloat("vol", 0.5f);
        }
        if (!PlayerPrefs.HasKey("key_gift"))
        {
          Debug.Log("gg");
          hi.SetActive(true);
          int k = PlayerPrefs.GetInt("keys");
          k += 10;
          PlayerPrefs.SetInt("keys", k);
          PlayerPrefs.SetInt("key_gift", 1);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
