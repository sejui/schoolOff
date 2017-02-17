using UnityEngine;
using System.Collections;

public class obstacleSpawn : MonoBehaviour {

	public GameObject powerUp;
	public GameObject powerUp2;
	public GameObject powerUp3;

	public GameObject obstacle1;
	public GameObject obstacle2;

	public float maxPos = 1.5f;
	public float minPos = -2f;
	float timer;
	float timer2;
	public float delayTimer = 300f;
	public float obstacleTimer = 1f;

	// Use this for initialization
	void Start () {

		timer = delayTimer;
		timer2 = obstacleTimer;
	}
	
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;
		timer2 -= Time.deltaTime;
		if (timer <= 0) {
			
			Vector3 powerUpPos = new Vector3 (Random.Range (-2f, 1.5f), transform.position.y, transform.position.z);

			Instantiate (powerUp, powerUpPos,transform.rotation);

			Vector3 powerUpPos2 = new Vector3 (Random.Range (-2f, 1.5f), transform.position.y, transform.position.z);

			Instantiate (powerUp2, powerUpPos2,transform.rotation);



			timer = delayTimer; //timer returns to delaytimer

			}

		if (timer2 <= 0) {
			Vector3 powerUpPos3 = new Vector3 (Random.Range (-2f, 1.5f), transform.position.y, transform.position.z);
			Vector3 powerUpPos4 = new Vector3 (Random.Range (-2f, 1.5f), transform.position.y, transform.position.z);
			Instantiate (obstacle1, powerUpPos3,transform.rotation);
			Instantiate (obstacle2, powerUpPos4,transform.rotation);

			timer2 = obstacleTimer;
		}




	



	}
}
