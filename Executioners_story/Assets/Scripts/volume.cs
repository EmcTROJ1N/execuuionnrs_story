﻿using UnityEngine;
using Fungus;

public class volume : MonoBehaviour {

    // Reference to Audio Source component
    private AudioSource audioSrc;
    public WriterAudio volume_dialog_script;

    // Music volume variable that will be modified
    // by dragging slider knob
    private float musicVolume;

	// Use this for initialization
	void Start () {

        // Assign Audio Source component to control it
        if (!PlayerPrefs.HasKey("vol"))
        {
          PlayerPrefs.SetFloat("vol", 0.5f);
        }
        musicVolume = PlayerPrefs.GetFloat("vol");
        audioSrc = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {

        // Setting volume option of Audio Source to be equal to musicVolume
        audioSrc.volume = PlayerPrefs.GetFloat("vol");
	}

    // Method that is called by slider game object
    // This method takes vol value passed by slider
    // and sets it as musicValue
    public void SetVolume_music(float vol)
    {
        musicVolume = vol;
        PlayerPrefs.SetFloat("vol", musicVolume);
    }
    public void SetVolume_dialog(float vol)
    {
        volume_dialog_script.volume = vol;
        PlayerPrefs.SetFloat("vol_dialog", vol);
    }
}
