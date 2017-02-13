using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public AudioClip myExplostion;
	public bool restart;
	// Use this for initialization
	void Start () {
		this.restart = false ;
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector3.down * Time.deltaTime * 5f);
		if (restart) {
			if (Input.GetKeyDown (KeyCode.R))
			{
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}

	void OnTriggerEnter(Collider other){
		Destroy (other.gameObject);
		this.restart = true;
		this.gameObject.GetComponent<AudioSource> ().clip = myExplostion;
		this.gameObject.GetComponent<AudioSource> ().Play ();
	}

	bool getRestart(){
		return this.restart;
	}
}
