using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerController : MonoBehaviour {
	public float playerSpeed;
	Vector3 position;
	public float maxPos;

	public GameObject bullet;

	public gameUi ui;

	// Use this for initialization
	void Start () {
		position = transform.position;
		maxPos = 2f;
		Time.timeScale = 1;
		InvokeRepeating ("magUpdate", 1.0f,1f);

	}

	void magUpdate(){

	}
	
	// Update is called once per frame
	void Update () {
		//x position increment based on horizontal arrow key input multiple by speed and frame time
		position.x += Input.GetAxis ("Horizontal") * playerSpeed * Time.deltaTime;

		position.x = Mathf.Clamp (position.x, -2f, 1.86f); //move player in a range of -2f to 1.86f

		transform.position = position; 

		if (Input.GetKeyDown("space")) {
			// Create a new bullet at “transform.position”
			// Which is the current position of the ship
			Instantiate(bullet, transform.position, Quaternion.identity);
		}
	}
		
		
}
