using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class disable_saydialog : MonoBehaviour
{
    public DialogInput script;
    public void tumbler_saydialog()
    {
      switch (script.mode)
      {
        case "Disabled":
        script.mode = "ClickAnywhere";
        break;
        case "ClickAnywhere":
        script.mode = "Disabled";
        break;
      }
    }

}
