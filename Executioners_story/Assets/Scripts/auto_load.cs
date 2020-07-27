using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class auto_load : MonoBehaviour
{
    // Start is called before the first frame update
    public SaveMenu saver;
    void Start()
    {
      saver.Load();
    }
    public void save_gam()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
