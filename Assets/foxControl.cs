using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foxControl : MonoBehaviour {


	private int moveAmount;

	// Use this for initialization
	void Start () {
		moveAmount = 0;
	}

	// Update is called once per frame
	void Update () {

		if (DustParticleController.counter >= 1){
			foreach (Transform child in transform) {
            child.position += Vector3.forward * 0.1F;
						moveAmount++;
						child.position += Vector3.zero;
						if (moveAmount >= 10){
							child.position += Vector3.forward * 0.0F;
						}

        }
		}

	}
}
