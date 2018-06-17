using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroMoveScript : Hero {

	public float moveSpeed;
	public float jumpImpulse;
	public float attackSpeed;
	private float speed;
	private bool isGround = false;

	private float attackTime = 0;

	private Rigidbody2D rb;
	private Animator animator;
	private Transform tr;

	private int lastButton = -1; // Right = 2, Left = 1

	void Start () {
		rb = GetComponent<Rigidbody2D> ();	
		animator = GetComponent<Animator> ();
		tr = GetComponent<Transform> ();
	}
		
	public override void leftButtonDown() {
		speed = -1;
		lastButton = 1;
		tr.localRotation = Quaternion.Euler (0, 0, 0);
		//animator.Play ("run");
		animator.SetFloat ("speed", Mathf.Abs(speed));
	}

	public override void rightButtonDown() {
		speed = 1;
		lastButton = 2;
		tr.localRotation = Quaternion.Euler (0, 180, 0);
		//animator.Play ("run");
		animator.SetFloat ("speed", Mathf.Abs(speed));
	}

	public override void leftButtonUp() {
		if (lastButton == 1) {
			lastButton = -1;
			speed = 0;
			//animator.Play ("idle");
			animator.SetFloat ("speed", Mathf.Abs(speed));
		}
	}

	public override void rightButtonUp() {
		if (lastButton == 2) {
			lastButton = -1;
			speed = 0;
			//animator.Play ("idle");
			animator.SetFloat ("speed", Mathf.Abs(speed));
		}
	}

	public override void stop() {
		speed = 0;
	}

	public override void jump() {
		if (isGround) {
			rb.AddForce (new Vector2 (0, jumpImpulse), ForceMode2D.Impulse);
			//animator.Play ("idle");
		}
	}

	public override void attack() {
		if (attackTime + attackSpeed < Time.time) {
			animator.Play ("attack");
			attackTime = Time.time + attackSpeed;
		}

	}

	void FixedUpdate() {
		rb.velocity = new Vector2 (speed * moveSpeed, rb.velocity.y);
	}
		
	void Update () {
		if (transform.position.y < -300) {
			SceneManager.LoadScene (0);
		}
	}

	public override void moveCamera (Camera _camera)
	{
		_camera.transform.position = new Vector3 (tr.transform.position.x, tr.transform.position.y, _camera.transform.position.z);
	}

	void OnTriggerEnter2D(Collider2D c) {
		if (c.tag == "Ground")
			isGround = true;
	}

	void OnTriggerStay2D(Collider2D c) {
		if (c.tag == "Ground")
			isGround = true;
	}

	void OnTriggerExit2D(Collider2D c) {
		if (c.tag == "Ground")
			isGround = false;
	}
}
