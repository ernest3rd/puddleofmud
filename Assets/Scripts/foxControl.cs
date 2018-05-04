using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class foxControl : MonoBehaviour {

	public float speed = 100f;
	public float rotSpeed = 100f;

	private int moveAmount;
	public Vector3 target = new Vector3 (0f, 30f, 0f);
	public float rotTarget = 0f;


	private bool begin;
	private bool firstScene;
	private bool firstSceneEnd;
	private bool secondScene;
	private bool secondSceneEnd;
	private bool thirdScene;
	private bool thirdSceneEnd;
	private bool fourthScene;
	private bool fourthSceneEnd;
	private bool fifthScene;
	private bool fifthSceneEnd;
	private bool sixthScene;
	private bool sixthSceneEnd;
	private bool seventhScene;
	private bool seventhSceneEnd;
	private bool eigthScene;
	private bool eigthSceneEnd;
	private bool ninthScene;
	private bool ninthSceneEnd;
	private bool tenthScene;
	private bool tenthSceneEnd;
	public Text winText;


	// Use this for initialization
	void Start () {
		moveAmount = 0;
	}

	// Update is called once per frame
	void Update () {



			float dist = Vector3.Distance(target, transform.position);
			Vector3 direction = (target - transform.position).normalized;
			if(dist > 0.5f){
				transform.position += dist * direction * speed * Time.deltaTime;
			}

			float rotation = (rotTarget - transform.rotation.eulerAngles.y);
			if(Mathf.Abs(rotation) > 0.1f){
				rotation /= 180;
				transform.Rotate(0, rotation * rotSpeed * Time.deltaTime, 0);
			}

			if (DustParticleController.counter >= 0 && begin == false) {

					target = new Vector3 (2f, 30f, 9f);
					rotTarget = 0f;

					begin = true;
			}

			if (DustParticleController.counter >= 20 && firstScene == false) {

					target = new Vector3 (-1f, 1f, 0f);
					rotTarget = 180f;
					StartCoroutine(FadeTextToFullAlpha(1f, winText.GetComponent<Text>()));
					winText.text = "Look at those legs.";
					firstScene = true;

			}

			if (DustParticleController.counter >= 40 && firstSceneEnd == false) {

					target = new Vector3 (10f, 30f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToZeroAlpha(1f, winText.GetComponent<Text>()));
					firstSceneEnd = true;

			}

			if (DustParticleController.counter >= 60 && secondScene == false) {

					target = new Vector3 (10f, 0f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToFullAlpha(1f, winText.GetComponent<Text>()));
					winText.text = "Hey, why are you collecting fluff?";
					secondScene = true;

			}

			if (DustParticleController.counter >= 80 && secondSceneEnd == false) {

					target = new Vector3 (10f, 30f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToZeroAlpha(1f, winText.GetComponent<Text>()));
					secondSceneEnd = true;

			}

			if (DustParticleController.counter >= 100 && thirdScene == false) {

					target = new Vector3 (10f, 0f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToFullAlpha(1f, winText.GetComponent<Text>()));
					winText.text = "I bet you can't get your feet as fluffy as my cloud.";
					thirdScene = true;

			}

			if (DustParticleController.counter >= 120 && thirdSceneEnd == false) {

					target = new Vector3 (10f, 30f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToZeroAlpha(1f, winText.GetComponent<Text>()));
					thirdSceneEnd = true;

			}

			if (DustParticleController.counter >= 140 && fourthScene == false) {

					target = new Vector3 (10f, 0f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToFullAlpha(1f, winText.GetComponent<Text>()));
					winText.text = "But please do.";
					fourthScene = true;

			}

			if (DustParticleController.counter >= 160 && fourthSceneEnd == false) {

					target = new Vector3 (10f, 30f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToZeroAlpha(1f, winText.GetComponent<Text>()));
					fourthSceneEnd = true;

			}

			if (DustParticleController.counter >= 180 && fifthScene == false) {

					target = new Vector3 (10f, 0f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToFullAlpha(1f, winText.GetComponent<Text>()));
					winText.text = "Or the consequences will be...";
					fifthScene = true;

			}

			if (DustParticleController.counter >= 200 && fifthSceneEnd == false) {

					target = new Vector3 (10f, 30f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToZeroAlpha(1f, winText.GetComponent<Text>()));
					fifthSceneEnd = true;

			}

			if (DustParticleController.counter >= 220 && sixthScene == false) {

					target = new Vector3 (10f, 0f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToFullAlpha(1f, winText.GetComponent<Text>()));
					winText.text = "A holiday with me!";
					sixthScene = true;

			}

			if (DustParticleController.counter >= 240 && sixthSceneEnd == false) {

					target = new Vector3 (10f, 30f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToZeroAlpha(1f, winText.GetComponent<Text>()));
					sixthSceneEnd = true;

			}

			if (DustParticleController.counter >= 260 && seventhScene == false) {

					target = new Vector3 (10f, 0f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToFullAlpha(1f, winText.GetComponent<Text>()));
					winText.text = "Do you know what happened to the others?";
					seventhScene = true;

			}

			if (DustParticleController.counter >= 280 && seventhSceneEnd == false) {

					target = new Vector3 (10f, 30f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToZeroAlpha(1f, winText.GetComponent<Text>()));
					seventhSceneEnd = true;

			}

			if (DustParticleController.counter >= 300 && eigthScene == false) {

					target = new Vector3 (10f, 0f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToFullAlpha(1f, winText.GetComponent<Text>()));
					winText.text = "Hey, what's that over there?";
					eigthScene = true;

			}

			if (DustParticleController.counter >= 320 && eigthSceneEnd == false) {

					target = new Vector3 (10f, 30f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToZeroAlpha(1f, winText.GetComponent<Text>()));
					eigthSceneEnd = true;

			}

			if (DustParticleController.counter >= 340 && ninthScene == false) {

					target = new Vector3 (10f, 0f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToFullAlpha(1f, winText.GetComponent<Text>()));
					winText.text = "Technology hurts.";
					ninthScene = true;

			}

			if (DustParticleController.counter >= 360 && ninthSceneEnd == false) {

					target = new Vector3 (10f, 30f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToZeroAlpha(1f, winText.GetComponent<Text>()));
					ninthSceneEnd = true;

			}

			if (DustParticleController.counter >= 380 && tenthScene == false) {

					target = new Vector3 (10f, 0f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToFullAlpha(1f, winText.GetComponent<Text>()));
					winText.text = "Follow me.";
					tenthScene = true;

			}

			if (DustParticleController.counter >= 400 && tenthSceneEnd == false) {

					target = new Vector3 (10f, 30f, 9f);
					rotTarget = 150f;
					StartCoroutine(FadeTextToZeroAlpha(1f, winText.GetComponent<Text>()));
					tenthSceneEnd = true;

			}



	}

	 IEnumerator FadeTextToFullAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
    }

     IEnumerator FadeTextToZeroAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
}
