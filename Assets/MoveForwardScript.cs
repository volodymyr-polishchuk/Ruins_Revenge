using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardScript : MonoBehaviour {

	private Transform objectTransform;

	void Start () {
		objectTransform = GetComponent<Transform> ();
	}
	
	void FixedUpdate () {
		if (objectTransform != null) {
			objectTransform.Translate (objectTransform.forward);
		}
	}

	void OnTriggerEnter2D(Collider2D c) {
		Debug.Log ("TriggerEnter");
		Destroy (transform.gameObject);
	}
}
