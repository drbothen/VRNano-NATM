using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExhibitAction : MonoBehaviour {

    public GameObject photo;
    private AudioSource _audio_source;

    // Use this for initialization
    void Start () {
            _audio_source = gameObject.GetComponent<AudioSource>();
            _audio_source.playOnAwake = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void popupPhoto() {
        photo.SetActive(true);
        Debug.Log("popup Photo Was pressed");
        if (_audio_source)
        {
            Console.Write("made it");
            _audio_source.Play();
        }
    }

    public void closePopup()
    {
        if (_audio_source)
        {
            _audio_source.Play();
        }
        photo.SetActive(false);

    }
}
