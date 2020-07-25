using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class load_on_start : MonoBehaviour
{
    public SaveMenu script;
    // Start is called before the first frame update
    public void Load_game()
    {
      script.Load();  
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
