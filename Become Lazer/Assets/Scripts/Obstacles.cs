using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {

	public GameObject Player;

	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {

		if (gameObject.transform.position.y <= -6f) {
			Destroy (gameObject);
		}

	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("Collided with particles");

		//Player.GetComponent<TrailRendererTest> ().lifeTime = 0f;
		StartCoroutine (DestroyPlayer ());
	}

	IEnumerator DestroyPlayer(){

		yield return new WaitForSeconds (0.08f);
		Destroy(Player);
	}
}
