using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HUD : MonoBehaviour {
	public GameObject cam;
	public int PlayerScore ;
	public Text ScoreText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Score ();
	}

	void Score () {
		PlayerScore = Mathf.RoundToInt(cam.transform.position.y/2f);
		ScoreText.text = "Score :" + PlayerScore.ToString ();

		//PlayerScore = cam.transform.position.y;
	}
}
