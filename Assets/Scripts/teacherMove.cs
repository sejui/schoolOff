using UnityEngine;
using System.Collections;

public class teacherMove : MonoBehaviour {

	public float speed = 5f;
	Vector3 teacherPos;
	private int magnitude;
	private float direction;

	public GameObject bullet;

	bool fire;

	// Use this for initialization
	void Start () {
		teacherPos = transform.position;
		InvokeRepeating ("magUpdate", 1.0f,1f);

	}

	void magUpdate(){
		magnitude = Random.Range (-1, 1);
		if (magnitude < 0) {
			direction = -2;
			fire = true;

		} else {
			direction = 2;
			fire = false;
		}
		if (fire) {
			Instantiate(bullet, transform.position, Quaternion.identity);
		}

	}

	// Update is called once per frame
	void Update () {



		teacherPos.x += direction* speed*Time.deltaTime;  
		teacherPos.x = Mathf.Clamp (teacherPos.x, -2f, 2f);

		transform.position = teacherPos;


	}


}
