using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Camera _camera;
	public Hero hero;

	void LateUpdate() {
		hero.moveCamera (_camera);
	}

	public void leftButtonDown() {
		if (hero != null)
			hero.leftButtonDown();
	}

	public void leftButtonUp() {
		if (hero != null)
			hero.leftButtonUp();
	}

	public void rightButtonDown() {
		if (hero != null)
			hero.rightButtonDown ();
	}

	public void rightButtonUp() {
		if (hero != null)
			hero.rightButtonUp ();
	}

	public void jump() {
		if (hero != null)
			hero.jump ();
	}

	public void attack() {
		if (hero != null)
			hero.attack ();
	}

	void checkKeyBoard() {
		if (Input.GetKeyDown (KeyCode.A)) leftButtonDown ();
		if (Input.GetKeyDown (KeyCode.D)) rightButtonDown ();

		if (Input.GetKeyUp (KeyCode.A)) leftButtonUp (); 
		if (Input.GetKeyUp (KeyCode.D)) rightButtonUp ();

		if (Input.GetKeyDown (KeyCode.Space)) jump ();

		if (Input.GetKeyDown (KeyCode.RightControl))
			attack ();
	}

	void Update() {
		checkKeyBoard ();
	}
}
