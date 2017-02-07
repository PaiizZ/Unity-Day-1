using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public AudioClip myExplostion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector3.up * Time.deltaTime * 10f);
		if (this.gameObject.transform.position.y >= 15f) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter(Collider other){
		Debug.Log ("Hello");
		Destroy (other.gameObject);
		this.gameObject.GetComponent<AudioSource> ().clip = myExplostion;
		this.gameObject.GetComponent<AudioSource> ().Play ();
//		Destroy (this.gameObject);
	}
}
