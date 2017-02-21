using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BulletController : MonoBehaviour {

	public AudioClip myExplostion;
	public int score;
	public ScoreText scoreText;
	// Use this for initialization


	void Start () {
		//		scoreText = GetComponent <Text> ();
		scoreText = ScoreText.instance;
		score = 0;
	}

	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector3.up * Time.deltaTime * 10f);
		//		scoreText.text = "Score: "+score;
		if (this.gameObject.transform.position.y >= 15f) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Enemy") {

			ScoreText.instance.AddScore (1);

			Destroy (other.gameObject);

			this.gameObject.GetComponent<AudioSource> ().clip = myExplostion;
			this.gameObject.GetComponent<AudioSource> ().Play ();
		}
		//		Debug.Log ("Hello");

		//		Destroy (this.gameObject);
	}
}