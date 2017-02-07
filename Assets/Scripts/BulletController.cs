using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector3.up * Time.deltaTime * 10f);
		if (this.gameObject.transform.position.y >= 20f) {
			Destroy (this.gameObject);
		}
	}
}
