﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class WizardMoveScript : MonoBehaviour {

	public float moveSpeed;
	public float jumpImpulse;
	private float speed;
	private bool isGround = true;

	private Rigidbody2D rb;
	private Animator animator;
	private Transform tr;

	private int lastButton = -1; // Right = 2, Left = 1

	void Start () {
		rb = GetComponent<Rigidbody2D> ();	
		animator = GetComponent<Animator> ();
		tr = GetComponent<Transform> ();
	}

	public void leftButtonDown() {
		speed = -1;
		lastButton = 1;
		tr.localRotation = Quaternion.Euler (0, 0, 0);
		animator.Play ("hero_wizard_run");
	}

	public void rightButtonDown() {
		speed = 1;
		lastButton = 2;
		tr.localRotation = Quaternion.Euler (0, 180, 0);
		animator.Play ("hero_wizard_run");
	}

	public void leftButtonUp() {
		if (lastButton == 1) {
			lastButton = -1;
			speed = 0;
			animator.Play ("hero_wizard_idle");
		}
	}

	public void rightButtonUp() {
		if (lastButton == 2) {
			lastButton = -1;
			speed = 0;
			animator.Play ("hero_wizard_idle");
		}
	}

	public void stop() {
		speed = 0;
	}

	public void jump() {
		if (isGround) {
			rb.AddForce (new Vector2 (0, jumpImpulse), ForceMode2D.Impulse);
			animator.Play ("hero_wizard_idle");
		}
	}

	public void attack() {
		animator.Play ("hero_wizard_attack");
	}

	void checkKeyBoard() {
		if (Input.GetKeyDown (KeyCode.A)) leftButtonDown ();
		if (Input.GetKeyDown (KeyCode.D)) rightButtonDown ();

		if (Input.GetKeyUp (KeyCode.A)) leftButtonUp (); 
		if (Input.GetKeyUp (KeyCode.D)) rightButtonUp ();

		if (Input.GetKeyDown (KeyCode.Space)) jump ();
	}

	void FixedUpdate() {
		checkKeyBoard ();
		rb.velocity = new Vector2 (speed * moveSpeed, rb.velocity.y);
	}
		
	void Update () {
		if (transform.position.y < -300) {
			SceneManager.LoadScene (0);
		}
	}
}
