using UnityEngine;
using System.Collections;

public class characterSpawn : MonoBehaviour {
	public GameObject player;
	public healthTrigger health;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void spawn () {
		Instantiate (player, transform.position,transform.rotation);
		health.health = 3;
	}
}
