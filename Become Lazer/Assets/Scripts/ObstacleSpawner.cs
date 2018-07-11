using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {


	public GameObject Obstacle;

	public float TimeUntilNextObstacle;
	public float TimeSeconds;

	private float XPosSpawnPoint;
	private Transform PositionOfSpawn;

	// Use this for initialization
	void Start () {
		PositionOfSpawn = gameObject.transform;
		//InvokeRepeating ("SpawnObstacle",TimeSeconds, TimeUntilNextObstacle);
	}
	
	// Update is called once per frame
	void Update () {		
		TimeSeconds -= Time.fixedDeltaTime * 0.015f;
		TimeUntilNextObstacle -= Time.deltaTime;

		if (TimeUntilNextObstacle <= 0f) {
			SpawnObstacle ();
			TimeUntilNextObstacle = TimeSeconds;
		}

	}


	void SpawnObstacle(){
		Vector3 Pos;

		Pos.x = Random.Range (-2, 2);
		Pos.y = PositionOfSpawn.position.y;
		Pos.z = PositionOfSpawn.position.z;


		Instantiate (Obstacle, Pos, Quaternion.identity);
	}

}
