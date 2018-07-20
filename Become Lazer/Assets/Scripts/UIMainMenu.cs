using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainMenu : MonoBehaviour {

	private GameObject OptionsMenu;

	// Use this for initialization
	void Start () {
		OptionsMenu = GameObject.Find ("OptionsMenu");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ExitGame(){

		Application.Quit ();
	}

	public void PlayGame(){
		// add script to go to the main game. SceneManager.loadScene();
	}

	public void Upgrades(){
		//add upgrades code here.
	}
		
}

