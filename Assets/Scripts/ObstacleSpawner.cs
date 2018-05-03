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
	}
}
