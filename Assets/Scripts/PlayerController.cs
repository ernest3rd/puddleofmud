using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float walkingSpeed = 4f;
	public float maxSeparation = 2f;
	public float stepBounciness = 1f;
	public float stepLift = 5f;

	public GameObject leftFootTarget;
	public GameObject rightFootTarget;
	public GameObject leftFoot;
	public GameObject rightFoot;

	private GameObject steppingFootTarget;
	private GameObject groundedFootTarget;
	private GameObject steppingFoot;
	private GameObject groundedFoot;


	private Vector3 stepVel;
	private Vector3 globalVel;

	private Vector3 startingPosition;

	private float totalDistance = 0;

	// Use this for initialization
	void Start () {
		stepVel = Vector3.zero;
		globalVel = Vector3.zero;
		startingPosition = Vector3.zero + transform.position;
		switchFeet ();
		totalDistance = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 vel = Vector3.zero;

		/*if (Input.GetKey (KeyCode.DownArrow)) {
			vel.x = -1f;
		}
		else*/ 
		if (Input.GetKey (KeyCode.UpArrow)) {
			vel.x = 1f;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			vel.z = 1f;
		}
		else if (Input.GetKey (KeyCode.RightArrow)) {
			vel.z = -1f;
		}
			
		float distA = Vector3.Distance (
			new Vector3 (groundedFootTarget.transform.position.x, 0, groundedFootTarget.transform.position.z), 
			new Vector3 (steppingFootTarget.transform.position.x, 0, steppingFootTarget.transform.position.z)
		);

		if (vel.magnitude > 0) {
			float distB = Vector3.Distance (
				              new Vector3 (groundedFootTarget.transform.position.x, 0, groundedFootTarget.transform.position.z), 
				              new Vector3 (steppingFootTarget.transform.position.x, 0, steppingFootTarget.transform.position.z) + vel
			              );

			if (distA > distB || distA < maxSeparation) {
				vel = vel.normalized * walkingSpeed;
			}
			else {
				vel = vel.normalized * walkingSpeed * (1 / distA);
			}
		}

		vel += stepVel;
		stepVel.y -= walkingSpeed * 8f * Time.deltaTime;

		globalVel = new Vector3 (-vel.x, 0, 0);

		groundedFootTarget.transform.Translate (globalVel * Time.deltaTime);
		steppingFootTarget.transform.Translate (vel * Time.deltaTime);

		if (steppingFootTarget.transform.position.y < 0) {
			steppingFootTarget.transform.position = new Vector3 (
				steppingFootTarget.transform.position.x,
				0,
				steppingFootTarget.transform.position.z
			);
			switchFeet ();
		}

		groundedFoot.transform.rotation = Quaternion.LookRotation (Vector3.down, Vector3.right);

		Vector3 pos = transform.position;
		pos.z = (groundedFootTarget.transform.position.z + steppingFootTarget.transform.position.z) / 2f;
		pos.y = -stepBounciness / 3f + Mathf.Lerp (startingPosition.y, startingPosition.y + ((maxSeparation-distA) / maxSeparation) * stepBounciness, 0.4f);
		transform.position = pos;

		totalDistance += -globalVel.x * Time.deltaTime;
	}
			
	void switchFeet(){
		if (steppingFootTarget == leftFootTarget) {
			steppingFootTarget = rightFootTarget;
			groundedFootTarget = leftFootTarget;
			steppingFoot = rightFoot;
			groundedFoot = leftFoot;
		} else {
			steppingFootTarget = leftFootTarget;
			groundedFootTarget = rightFootTarget;
			steppingFoot = leftFoot;
			groundedFoot = rightFoot;
		}

		float distA = Vector3.Distance (
			new Vector3 (groundedFootTarget.transform.position.x, 0, groundedFootTarget.transform.position.z), 
			new Vector3 (steppingFootTarget.transform.position.x, 0, steppingFootTarget.transform.position.z)
		);
		//float distA = Mathf.Abs (groundedFootTarget.transform.position.x - steppingFootTarget.transform.position.x);

		stepVel.y = stepLift * Mathf.Pow(distA, 0.2f);
	}

	public Vector3 getVelocity(){
		return globalVel;
	}

	public float getTotalDistance(){
		return totalDistance;
	}
}
