using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donate : MonoBehaviour
{
    // Start is called before the first frame update
    public void OpenBrowser(string url_from_chat) {
        Application.OpenURL(url_from_chat); // ←- Badness here; value isn’t sanitized
    }}
