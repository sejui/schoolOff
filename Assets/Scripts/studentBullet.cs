using UnityEngine;
using System.Collections;

public class studentBullet : MonoBehaviour {
	public float speed = 6f;
	Vector3 bulletPos;
	// Use this for initialization
	void Start () {
		bulletPos = transform.position;
	
	}

	// Update is called once per frame
	void Update () {
		bulletPos.y += speed * Time.deltaTime;
		transform.position = bulletPos; 
	}
		

	public void onBecameInvisible(){
		
	}
}
