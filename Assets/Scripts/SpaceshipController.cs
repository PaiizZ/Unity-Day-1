﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpaceshipController : MonoBehaviour {
	[System.Serializable]
	public class Boundary{
		public float xMin , xMax ,yMin, yMax;
	}
	public GameObject myBullet;
	public static SpaceshipController instance;
	// Use this for initialization
	public float speed;
	public Text gameOverText;
	public Boundary boundary;
	public bool restart;
	void Start () {
//		gameOverText = GetComponent<Text>();
		if (instance==null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space)) {
			Instantiate (myBullet, this.gameObject.transform.position,Quaternion.identity);
		}
		if (restart) {
			Debug.Log ("eiei restart");
			gameOverText.text = "Game Over";
			if (Input.GetKeyDown (KeyCode.R))
			{
				Debug.Log ("eiei");
				gameOverText.text = "kjkjjkk";
				Application.LoadLevel (Application.loadedLevel);
				this.restart = false;
			}
		}
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f); 
		GetComponent<Rigidbody>().velocity = movement * speed;﻿

		GetComponent<Rigidbody> ().position = new Vector3 (
			Mathf.Clamp (GetComponent<Rigidbody> ().position.x, boundary.xMin, boundary.xMax), 
			Mathf.Clamp (GetComponent<Rigidbody> ().position.y, boundary.yMin, boundary.yMax),
			0.0f
		);
			
	}

	public void setRestart(bool re){
		this.restart = re;
	}
		
}
