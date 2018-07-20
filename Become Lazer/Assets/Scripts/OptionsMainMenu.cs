using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMainMenu : MonoBehaviour {

	public AudioMixer MainMixer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeVolume (float Volume){

		MainMixer.SetFloat ("VolumeParameter", Volume);
	}
}
