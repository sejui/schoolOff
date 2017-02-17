using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class uiManager : MonoBehaviour {

	public Canvas instruction;
	public Canvas start;
	public Canvas Volumn;

	//public Canvas game;

	public Image page1;
	public Image page2;
	public Image page3;
	public Image page4;

	int click=0;
	int maxClick=4;
	// Use this for initialization
	void Start () {
		instruction = instruction.GetComponent<Canvas> ();
		start = start.GetComponent<Canvas> ();
		Volumn = Volumn.GetComponent<Canvas> ();

		start.enabled = true;
		instruction.enabled = false;
		Volumn.enabled = false;

		page1.enabled = false;
		page2.enabled = false;
		page3.enabled = false;
		page4.enabled = false;


	}
	
	// Update is called once per frame
	void Update () {
		if (click == 0) {
			page1.enabled = false;
			page2.enabled = false;
			page3.enabled = false;
			page4.enabled = false;
		} else if (click == 1) {
			page1.enabled = true;
			page2.enabled = false;
			page3.enabled = false;
			page4.enabled = false;
		} else if (click == 2) {
			page1.enabled = false;
			page2.enabled = true;
			page3.enabled = false;
			page4.enabled = false;
		} else if (click == 3) {
			page1.enabled = false;
			page2.enabled = false;
			page3.enabled = true;
			page4.enabled = false;
		} else if (click >= 4) {
			page1.enabled = false;
			page2.enabled = false;
			page3.enabled = false;
			page4.enabled = true;
			click = maxClick;
		} else {
			click = 0;
		}
	}

	public void Play(){
		Application.LoadLevel ("gameplay");
	}

	public void Gui1(){
		instruction.enabled = false;
		Volumn.enabled = false;
	}

	public void Gui2(){
		instruction.enabled = true;
	}

	public void volumn(){
		Volumn.enabled = true;
	}

//	public void gameCanvas(){
//		game.enabled = true;
//		Volumn.enabled = false;
//	}

	public void rightBut(){
		click += 1;
	}

	public void leftBut(){
		click -= 1;
	}
}
