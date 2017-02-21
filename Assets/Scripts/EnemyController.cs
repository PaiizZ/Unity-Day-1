using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour {
	public AudioClip myExplostionBoom;
	public bool restart;
	// Use this for initialization
	public SpaceshipController space;
	void Start () {
		this.restart = false ;
		space = SpaceshipController.instance;
	}

	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector3.down * Time.deltaTime * 5f);
		if (restart) {
			if (Input.GetKeyDown (KeyCode.R))
			{
				space.gameOverText.text = "";
				Application.LoadLevel (Application.loadedLevel);
				this.restart = false;
			}
		}
	}

	void OnTriggerEnter(Collider other){
		
		if (other.gameObject.tag == "Player") {
			AudioSource.PlayClipAtPoint (myExplostionBoom, gameObject.transform.position);
			space.gameOverText.text = "Game Over!";
			this.restart = true;

			if (PlayerPrefs.GetInt("Highscore") < ScoreText.instance.getScore() ) {
				PlayerPrefs.SetInt ("Highscore", ScoreText.instance.getScore() );
			}

			Destroy (other.gameObject);
			waitTime ();
			SceneManager.LoadScene (0);
			//			this.gameObject.GetComponent<AudioSource> ().Play ();
		}

	}
	IEnumerator waitTime(){
		yield return new WaitForSeconds(10);
	}
}