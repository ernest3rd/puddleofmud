using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickTo : MonoBehaviour {

    public Transform friend;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = friend.position;
	}
}
