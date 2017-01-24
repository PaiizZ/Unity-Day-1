using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		GUI.Button (new Rect (Screen.width/2-25, Screen.height/2-25, 50, 50), "Button");

	}
}
