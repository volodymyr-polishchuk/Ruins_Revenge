using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScript : MonoBehaviour {

	public float horizontalSpeed;
	public float jumpImpulse;
	private float speed;
	private bool isGround = false;

	private Rigidbody2D rb2;
	private SpriteRenderer sr;

	void Start () {
		rb2 = GetComponent<Rigidbody2D> ();
		sr = GetComponent<SpriteRenderer> ();
	}

	public void leftButtonDown() {
		speed = -1;
		sr.flipX = false;
	}

	public void rightButtonDown() {
		speed = 1;
		sr.flipX = true;
	}

	public void stop () {
		speed = 0;
	}

	public void jump() {
		
		if (isGround)
			rb2.AddForce (new Vector2 (0, jumpImpulse), ForceMode2D.Impulse);
	}

	void Update() {
		if (transform.position.y < -300) {
			SceneManager.LoadScene (0);
		}
	}

	void FixedUpdate() {
		checkInputKeyBoard ();
		rb2.velocity = new Vector2(speed * horizontalSpeed, rb2.velocity.y);
		//transform.Translate (speed * horizontalSpeed, 0, 0);	
	}

	void checkInputKeyBoard() {
		if (Input.GetKeyDown (KeyCode.A)) {
			leftButtonDown ();
		} else if (Input.GetKeyDown (KeyCode.D)) {
			rightButtonDown ();
		}
		if (Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.D)) {
			stop ();
		}
		if (Input.GetKeyDown (KeyCode.Space) && isGround) {
			jump ();
		}
	}

	private void OnCollisionEnter2D(Collision2D c) {
		if (c.gameObject.tag == "Ground") {
			isGround = true;
		}
	}

	private void OnCollisionExit2D(Collision2D c) {
		if (c.gameObject.tag == "Ground") {
			isGround = false;
		}
	}
		
}
