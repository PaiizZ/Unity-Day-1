using UnityEngine;
using System.Collections;

public class SpaceshipController : MonoBehaviour {

	public GameObject myBullet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Horizontal") != 0 ) {
			this.gameObject.transform.Translate (Input.GetAxis ("Horizontal") * Vector3.right);
		} else if (Input.GetAxis("Vertical") != 0) {
			this.gameObject.transform.Translate (Input.GetAxis ("Vertical") * Vector3.up);
		} 

		if (Input.GetKey(KeyCode.Space)) {
			Instantiate (myBullet, this.gameObject.transform.position,Quaternion.identity);
		}
	}

}
