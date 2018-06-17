using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingScript : MonoBehaviour {

	public const string VOLUME_KEY = "VOLUME_KEY";
	public const string MUSIC_KEY = "MUSIC_KEY";
	public Slider slider;
	public Toggle toggle;

	public void ReturnToMainMenu() {
		PlayerPrefs.SetFloat (VOLUME_KEY, slider.value);
		AudioListener.volume = slider.value;

		PlayerPrefs.SetInt (MUSIC_KEY, toggle.isOn ? 1 : 0);
		PlayerPrefs.Save();
		SceneManager.LoadScene ("MainMenuScene", LoadSceneMode.Single);
	}

	void Awake() {
		slider.value = PlayerPrefs.GetFloat (VOLUME_KEY, 0);
		toggle.isOn = PlayerPrefs.GetInt (MUSIC_KEY, 0) == 1;
	}
}
