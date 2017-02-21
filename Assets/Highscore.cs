using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {

	void Start () {
		this.gameObject.GetComponent<Text> ().text = "Highscore : "+PlayerPrefs.GetInt ("Highscore").ToString ();

	}
}
