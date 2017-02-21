using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreText : MonoBehaviour {

	public static ScoreText instance;

	public int score = 0;

	// Use this for initialization
	void Start () {
//		DontDestroyOnLoad (this.gameObject);
		if (instance==null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
	}

	
	void setText(string newText){
		GetComponent<Text> ().text = "Score : "+newText;
				
	}

	public int getScore(){
		return this.score;
	}

	public void AddScore(int val){
		score += val;
		setText (score+"");
	}

}
