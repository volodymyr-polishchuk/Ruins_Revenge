using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseButtonScript : MonoBehaviour {

	private bool pause = false;
	public Text text;

	public void pauseGame() {
		if (pause) {
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

	public void goToMainManu() {
		SceneManager.LoadScene ("MainMenuScene", LoadSceneMode.Single);
	}

}
