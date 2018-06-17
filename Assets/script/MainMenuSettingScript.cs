using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSettingScript : MonoBehaviour {

	public void OnSettingButtonClick() {
		SceneManager.LoadScene ("SettingScene", LoadSceneMode.Single);
	}
}
