using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foxControl : MonoBehaviour {

	public float speed = 1f;

	private int moveAmount;
	public Vector3 target = new Vector3 (0, 0, 0);

	// Use this for initialization
	void Start () {
		moveAmount = 0;
	}

	// Update is called once per frame
	void Update () {



		if (DustParticleController.counter >= 1){
			Vector3 direction = (target - transform.position).normalized;
			transform.position += direction * speed * Time.deltaTime;
		}

	}
}
