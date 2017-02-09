using UnityEngine;
using System.Collections;

public class SpawnEnemyController : MonoBehaviour {

	public GameObject myEnemy;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}	

	IEnumerator SpawnEnemy(float waitTime) {

		Instantiate (myEnemy, this.gameObject.transform.position, Quaternion.identity);

		yield return new WaitForSeconds(waitTime);
		StartCoroutine (SpawnEnemy (1f));
	}
		
}
