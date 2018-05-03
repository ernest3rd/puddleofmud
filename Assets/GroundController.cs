using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour {

	public PlayerController pc;

	private float radian = 180 / Mathf.PI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float dist = -(pc.getVelocity ()).x;

		float rotation = Mathf.Atan(dist/160) * radian;

		Debug.Log (rotation);

		transform.Rotate (0, 0, rotation * Time.deltaTime);

	}
}
