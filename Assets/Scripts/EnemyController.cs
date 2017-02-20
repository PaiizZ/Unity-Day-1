using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {
	public AudioClip myExplostionBoom;
	public SpaceshipController spaceship;
//	public Text gameOverText;

	// Use this for initialization
	void Start () {
//		gameOverText = GetComponent<Text>();
		spaceship = SpaceshipController.instance;
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector3.down * Time.deltaTime * 5f);

	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			AudioSource.PlayClipAtPoint (myExplostionBoom, gameObject.transform.position);
//			Debug.Log (other.gameObject.GetComponent<SpaceshipController> ().restart);
			spaceship.setRestart (true);
//			 Debug.Log (other.gameObject.GetComponent<SpaceshipController> ().restart);
			Destroy (other.gameObject);
			
//			this.gameObject.GetComponent<AudioSource> ().Play ();
		}
			
	}
		
}
