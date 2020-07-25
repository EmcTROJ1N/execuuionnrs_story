using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class disable_saydialog : MonoBehaviour
{
    public DialogInput script;
    public void tumbler_saydialog()
    {
      if (script.enabled)
      {
        script.enabled = false;
      }
      else
      {
        script.enabled = true;
      }
    }

}
