using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour {
	public GameObject lightObject;
	float i = 0 ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (Time.time +"  "+i);
		i++;
	}

	void OnGUI () {
		if (GUI.Button (new Rect (Screen.width/2-50, Screen.height/2-50, 100, 100), lightObject.GetComponent<Light>().enabled?"Turn Off":"Turn On")) {
			Debug.Log(Time.time + "Hello world");
			lightObject.GetComponent<Light> ().enabled = !lightObject.GetComponent<Light> ().enabled;

		}
	}
}
