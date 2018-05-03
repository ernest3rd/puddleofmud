using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

	public PlayerController pc;
	public GameObject tParent;
	public GameObject[] obstacles;
	public Transform topBoundary;
	public Transform bottomBoundary;

	private float nextSpawn;

	// Use this for initialization
	void Start () {
		nextSpawn = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		float dist = pc.getTotalDistance ();
		if (dist > nextSpawn) {
			nextSpawn = dist + Random.Range(1f, 10f);
			Vector3 newPos = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
			newPos.z = Random.Range (topBoundary.position.z, bottomBoundary.position.z);
			GameObject o = Instantiate<GameObject> (obstacles[0], newPos, transform.rotation, tParent.transform);
			o.GetComponent<ObstacleController> ().setPlayerController (pc);
		}

		if (pc.getVelocity().magnitude > 0 && Random.Range (0, 1000) < 200) {
			Vector3 newPos2 = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
			newPos2.z = Random.Range (topBoundary.position.z, bottomBoundary.position.z);
			newPos2.y += Random.Range (0, 2f);
			GameObject o2 = Instantiate<GameObject> (obstacles[1], newPos2, transform.rotation, tParent.transform);
			o2.GetComponent<ObstacleController> ().setPlayerController (pc);
		}
	}
}
