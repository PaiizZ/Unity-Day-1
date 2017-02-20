using UnityEngine;
using System.Collections;

public class SpawnEnemyController : MonoBehaviour {

	public GameObject myEnemy;
	private float x;
	private float y;
	private float z;
	private Vector3 positionSpawn;
	public ScoreText scoreText;
	// Use this for initialization
	void Start () {
		scoreText = ScoreText.instance;
		StartCoroutine (SpawnEnemy (1f));
	}
	
	// Update is called once per frame
	void Update () {

	}	



	IEnumerator SpawnEnemy(float waitTime) {

		x = Random.Range (-4, 4);
		y = 4;
		z = 0;
		positionSpawn = new Vector3 (x,y,z);
		Debug.Log (""+positionSpawn);
		Instantiate (myEnemy, positionSpawn, Quaternion.identity);

		yield return new WaitForSeconds(waitTime);
		if (scoreText.getScore () <= 10) {
			StartCoroutine (SpawnEnemy (1f));
		} else if (scoreText.getScore () <= 20) {
			StartCoroutine (SpawnEnemy (0.7f));
		} else {
			StartCoroutine (SpawnEnemy (0.3f));
		}
	}
		
}
