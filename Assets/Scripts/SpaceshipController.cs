using UnityEngine;
using System.Collections;

public class SpaceshipController : MonoBehaviour {
	[System.Serializable]
	public class Boundary{
		public float xMin , xMax ,yMin, yMax;
	}
	public GameObject myBullet;
	// Use this for initialization
	public float speed;
	public Boundary boundary;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetAxis("Horizontal") != 0 ) {
//			this.gameObject.transform.Translate (Input.GetAxis ("Horizontal") * Vector3.right);
//		} else if (Input.GetAxis("Vertical") != 0) {
//			this.gameObject.transform.Translate (Input.GetAxis ("Vertical") * Vector3.up);
//		} 

		if (Input.GetKeyDown(KeyCode.Space)) {
			Instantiate (myBullet, this.gameObject.transform.position,Quaternion.identity);
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


}
