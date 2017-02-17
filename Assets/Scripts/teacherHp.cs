using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class teacherHp : MonoBehaviour {
	public gameUi ui;
	public studentBullet damage;
	public Image hp1;
	public Image hp2;
	public Image hp3;

	public int health=1;
	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Bullet") {


			health--;
			Debug.Log ("hitByBulleey" + health);
			Destroy (other.gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
		if (health == 3) {
			hp1.enabled = true;
			hp2.enabled = true;
			hp3.enabled = true;
		} else if (health == 2) {
			hp1.enabled = true;
			hp2.enabled = true;
			hp3.enabled = false;
		} else if (health == 1) {
			hp1.enabled = true;
			hp2.enabled = false;
			hp3.enabled = false;
		} else if (health == 0) {
			hp1.enabled = false;
			hp2.enabled = false;
			hp3.enabled = false;
			Destroy (gameObject);
			ui.gameWin ();
		}
	}
}
