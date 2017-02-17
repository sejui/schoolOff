using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gameUi : MonoBehaviour {
	
	public Canvas volumn;
	public Canvas game;
	public Canvas lostScreen;
	public Text scoreText;
	public Canvas winScreen;
	//public characterSpawn playerSpawn;
	public int score=60;
	bool gameOver;

	// Use this for initialization
	void Start () {
		volumn.enabled = false;
		winScreen.enabled = false;
		game.enabled = true;


		InvokeRepeating ("scoreUpdate", 1.0f, 1f);

		gameOver = false;
		lostScreen.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "TIMER: " + score;


	}

	void scoreUpdate(){
		if (!gameOver) {
			score -= 1;
		} else {
			score -= 0;
		}
		if (score <= 0) {
			gameIsOver();
		}
	}

	public void gameIsOver(){
		gameOver = true;
		Time.timeScale = 0;
		lostScreen.enabled = true;
	}

	public void gameWin(){
		Time.timeScale = 0;
		winScreen.enabled = true;
	}

	public void restart(){
		Application.LoadLevel(Application.loadedLevel);
		gameOver = false;
	}
	public void nextLevel(){
		SceneManager.LoadScene ("gamePlay3");
	}
	public void loadLevel3(){
		SceneManager.LoadScene ("gamePlay2");
	}
	public void menu(){
		SceneManager.LoadScene ("intro");
	}

	public void gameCanvas(){
		game.enabled = true;
		volumn.enabled = false;
		Time.timeScale = 1;
	}
	public void stop(){
		if (Time.timeScale != 0) {
			Time.timeScale = 0;
		} else  {
			Time.timeScale = 1;
		}
	}

	public void volumnCanvas(){
		volumn.enabled = true;
		stop ();
	}

}
