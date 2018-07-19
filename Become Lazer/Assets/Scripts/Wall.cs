using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

	public GameObject Player;
	public Rigidbody2D PlayerRigidBody;

	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player");
		PlayerRigidBody = Player.GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/*void OnTriggerEnter2D(){
		PlayerRigidBody.velocity = Vector2.zero;
	}*/
}
