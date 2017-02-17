using UnityEngine;
using System.Collections;

public class destroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "lifeUp" ||
		   col.gameObject.tag == "sheild" ||
			col.gameObject.tag == "obstacle"||
			col.gameObject.tag == "bullet") {
			Destroy (col.gameObject);
		}
	}
}
