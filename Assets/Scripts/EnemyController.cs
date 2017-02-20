using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {
	public AudioClip myExplostionBoom;
	public bool restart;
	public Text gameOverText;
	// Use this for initialization
	void Start () {
		this.restart = false ;
		gameOverText = GetComponent<UnityEngine.UI.Text>();

	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector3.down * Time.deltaTime * 5f);
		if (restart) {
			if (Input.GetKeyDown (KeyCode.R))
			{
				gameOverText.text = "";
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			AudioSource.PlayClipAtPoint (myExplostionBoom, gameObject.transform.position);
			Destroy (other.gameObject);
			this.restart = true;
			GetComponent<UnityEngine.UI.Text>().text = "Game Over";
//			this.gameObject.GetComponent<AudioSource> ().Play ();
		}
			
	}

	bool getRestart(){
		return this.restart;
	}
}
