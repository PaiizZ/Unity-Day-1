using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {

	public void OnButtonIsClicked(){
		Debug.Log ("Button on clicked");
		SceneManager.LoadScene ("SpaceShip");
	}
}
