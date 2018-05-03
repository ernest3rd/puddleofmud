using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour {

	public PlayerController pc;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*Vector3 vel = pc.getVelocity ();
		transform.Translate(vel * Time.deltaTime);
*/
		if (transform.position.x < -10) {
			Destroy (gameObject);
		}
	}

	public void setPlayerController(PlayerController p){
		pc = p;
	}
}
