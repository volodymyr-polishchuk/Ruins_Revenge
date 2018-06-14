using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Camera c;
	public Transform t;
	
	// Update is called once per frame
	void Update () {
		c.transform.position = new Vector3 (t.transform.position.x, t.transform.position.y, c.transform.position.z);
	}
}
