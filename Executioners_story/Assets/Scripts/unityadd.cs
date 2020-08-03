using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class unityadd : MonoBehaviour
{
    void Start()
    {
      if (Advertisement.isSupported)
      {
        Advertisement.Initialize("3680455", false);
      }
    }

    // Update is called once per frame
    public void premka()
    {
      PlayerPrefs.SetInt("premium", 1);
      PlayerPrefs.SetInt("keys", 666);
    }
    public void add()
    {
        if(Advertisement.IsReady() && !PlayerPrefs.HasKey("premium"))
        {
          Advertisement.Show("video");
          int ads = PlayerPrefs.GetInt("adds");
          ads++;
          PlayerPrefs.SetInt("adds", ads);
        }
      }
    public void rew_add()
    {
        if(Advertisement.IsReady())
        {
          Advertisement.Show("rewardedVideo");
          int keys = PlayerPrefs.GetInt("keys");
          keys += 10;
          PlayerPrefs.SetInt("keys", keys);
          int ads = PlayerPrefs.GetInt("adds");
          ads++;
          PlayerPrefs.SetInt("adds", ads);
        }
    }
    public void OnUnityAdsDidFinish (string placementId, ShowResult showResult) {
        if (showResult == ShowResult.Finished)
        {
          int keys = PlayerPrefs.GetInt("keys");
          keys += 10;
          PlayerPrefs.SetInt("keys", keys);
        }
        else if (showResult == ShowResult.Skipped)
        {
          //
          Debug.LogWarning ("gg");
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning ("The ad did not finish due to an error.");
      }
}
    public void del_keys()
    {
      PlayerPrefs.SetInt("keys", 0);
      PlayerPrefs.DeleteKey("premium");
    }
}
