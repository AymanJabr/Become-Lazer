using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {


	public GameObject Obstacle;

	public float TimeUntilNextObstacle;

	private float XPosSpawnPoint;
	private Transform PositionOfSpawn;

	// Use this for initialization
	void Start () {
		PositionOfSpawn = gameObject.transform;
		InvokeRepeating ("SpawnObstacle", 1f, TimeUntilNextObstacle);
	}
	
	// Update is called once per frame
	void Update () {		
		//StartCoroutine (SpawnObstacle ());
	}


	void SpawnObstacle(){
		Vector3 Pos;

		Pos.x = Random.Range (-2, 2);
		Pos.y = PositionOfSpawn.position.y;
		Pos.z = PositionOfSpawn.position.z;


		Instantiate (Obstacle, Pos, Quaternion.identity);
	}

	/*IEnumerator SpawnObstacle(){
		while (true) {
			Vector3 Pos;

			Pos.x = Random.Range (-2, 2);
			Pos.y = PositionOfSpawn.position.y;
			Pos.z = PositionOfSpawn.position.z;


			Instantiate (Obstacle, Pos, Quaternion.identity);


			yield return new WaitForSeconds (TimeUntilNextObstacle);
		}
	}*/
}
