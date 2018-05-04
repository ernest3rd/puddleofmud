using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DustParticleController : MonoBehaviour {

	private GameObject[] slippers;
	private GameObject player;
	private Rigidbody rb;

	private Vector3 velocity = Vector3.zero;

	private bool connected = false;

	public static int counter;
	public Text countText;


	void Awake(){
		rb = GetComponent<Rigidbody> ();
	}

	// Use this for initialization
	void Start () {
		slippers = GameObject.FindGameObjectsWithTag ("Slippers");
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {
		Color c = gameObject.GetComponent<SpriteRenderer> ().color;
		c.a = 1f / Mathf.Max(0, Mathf.Abs(transform.position.x) - 5f);
		gameObject.GetComponent<SpriteRenderer> ().color = c;
	}

	void FixedUpdate(){
		if (!connected) {
			foreach (GameObject slipper in slippers) {
				float dist = Vector3.Distance (slipper.transform.position, transform.position);


				if (dist < 5f) {
					Vector3 pull = (slipper.transform.position - transform.position).normalized;
					if (dist < 2f) {
						pull *= dist + 0.1f;
						rb.velocity *= 0.9f;
					} else {
						pull *= 1f / (dist + 0.01f);
					}
					rb.AddForce (pull);
				}
			}
		}

		Vector3 wonder = new Vector3 (Random.Range (-1f, 1f), Random.Range (-1f, 1f), Random.Range (-1f, 1f));
		rb.AddForce (wonder * 0.01f);
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag ("Slippers")) {
			FixedJoint joint = gameObject.AddComponent<FixedJoint>();
			joint.connectedBody = collision.rigidbody;
			GetComponent<Collider> ().enabled = false;
			connected = true;
			if (connected == true){
				counter++;
			  Debug.Log(counter);
			}
		}
	}

}
