using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerController : MonoBehaviour {

	public Sprite[] flowerSprites;


	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().sprite = flowerSprites [(int)Random.Range (0, flowerSprites.Length)];	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
