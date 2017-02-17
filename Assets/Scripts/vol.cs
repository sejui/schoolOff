using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class vol : MonoBehaviour {

	//public float val = 0.02f;
	public AudioSource audio;
	public Slider volSlider;

	// Update is called once per frame
	void Update () {
		audio.volume = volSlider.value;
	}
}
