using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButtonScript : MonoBehaviour {

	private bool pause = false;
	private float timeSc;
	public Text text;

	public void pauseGame() {
		if (pause) {
			timeSc = Time.timeScale;
			Time.timeScale = 0;
			pause = !pause;
			if (text) {
				text.text = ">";
			}
		} else {
			Time.timeScale = 1;
			pause = !pause;
			if (text) {
				text.text = "||";
			}
		}
	}

}
