﻿﻿using UnityEngine;

public class volume : MonoBehaviour {

    // Reference to Audio Source component
    private AudioSource audioSrc;

    // Music volume variable that will be modified
    // by dragging slider knob
    private float musicVolume;

	// Use this for initialization
	void Start () {

        // Assign Audio Source component to control it
        musicVolume = PlayerPrefs.GetFloat("vol");
        audioSrc = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {

        // Setting volume option of Audio Source to be equal to musicVolume
        audioSrc.volume = musicVolume;
	}

    // Method that is called by slider game object
    // This method takes vol value passed by slider
    // and sets it as musicValue
    public void SetVolume(float vol)
    {
        musicVolume = vol;
        PlayerPrefs.SetFloat("vol", musicVolume);
    }
}
