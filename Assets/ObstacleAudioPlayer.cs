using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAudioPlayer : MonoBehaviour {

	public AudioClip[] primaryAudio;
	public AudioClip[] secondaryAudio;
	private AudioSource ass;
	private Material material;

	private int audioIndex = 0;


	void Awake(){
		ass = GetComponent<AudioSource> ();
	}

	// Use this for initialization
	void Start () {
		audioIndex = (int)Random.Range (0, primaryAudio.Length);
	}

	// Update is called once per frame
	void Update () {

	}

	void PlayAudio(AudioClip ac){
		ass.clip = ac;
		ass.Play ();
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.CompareTag ("Slippers")) {
			PlayAudio (secondaryAudio [audioIndex]);
		}
		else if(col.gameObject.CompareTag ("Marker")) {
			PlayAudio (primaryAudio [audioIndex]);
		}
	}

	/*void OnCollisionEnter(Collision col){
		if (col.gameObject.CompareTag ("Slippers")) {
			PlayAudio (secondaryAudio [audioIndex]);
		}
		else if(col.gameObject.CompareTag ("Marker")) {
			PlayAudio (primaryAudio [audioIndex]);
		}
	}*/
}
