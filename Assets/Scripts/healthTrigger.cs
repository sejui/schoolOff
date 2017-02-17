using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class healthTrigger : MonoBehaviour {
	public int health =3;
	public int maxHp = 3;
	bool isSheild = false;
	float invuln = 0;
	public Image hp1;
	public Image hp2;
	public Image hp3;
	public Image sheild;

	public gameUi ui;


	void start(){
		//player = player.GetComponent<GameObject> ();

	}

	void OnTriggerEnter2D(Collider2D other){
		//Debug.Log ("trigger!");
		//playerController player = new playerController();
		//player.hp--;
			//Destroy (gameObject);
			//player.playerController.hp--;
		if (other.gameObject.tag == "sheild" && !isSheild) {
			//Debug.Log ("health");
			invuln = 5f;
			isSheild = true;
			Destroy (other.gameObject);
			//playerController.UpdateHp
		} else if (other.gameObject.tag == "lifeUp" && (health < maxHp)) {

			//Debug.Log ("this is sheild");
			health++;
			Destroy (other.gameObject);

		} else if ((other.gameObject.tag == "obstacle"||other.gameObject.tag =="bullet") && !isSheild) {
			health--;
			Destroy (other.gameObject);
		} 
	}
	void Update(){
		invuln -= Time.deltaTime; //invincibilty when injuring 
		if (invuln <= 0f) {
			isSheild = false;
		}
		if (health <= 0) {
			Die ();
		}

		if (health == 3) {
			hp1.enabled=true;
			hp2.enabled = true;
			hp3.enabled = true;
		}

		if (health == 2) {
			hp1.enabled=true;
			hp2.enabled = true;
			hp3.enabled = false;
		}

		if (health == 1) {
			hp1.enabled=true;
			hp2.enabled = false;
			hp3.enabled = false;
		}

		if (health == 0) {
			hp1.enabled=false;
			hp2.enabled = false;
			hp3.enabled = false;

			ui.gameIsOver ();
		}

		if (isSheild) {
			sheild.enabled = true;
		} else {
			sheild.enabled = false;
		}

	}
	void respawn(){
		health = 3;

	}
	void Die(){

		Destroy (gameObject);
	}


	}

