using System.Collections;
using System.Collections.Generic;
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
}
