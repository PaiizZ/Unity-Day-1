using UnityEngine;
using System.Collections;

public class olo : MonoBehaviour {
	public bool restart;
	public static olo instance;
	// Use this for initialization
	public SpaceshipController spaceship;

	void Start () {
		spaceship = SpaceshipController.instance;
		if (instance==null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
		this.restart = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (restart) {
			if (Input.GetKeyDown (KeyCode.R))
			{
				spaceship.gameOverText.text = "";
				Application.LoadLevel (Application.loadedLevel);
				this.restart = false;
			}
		}
	}

	public void setRestart(bool re){
		this.restart = re;
	}
}
