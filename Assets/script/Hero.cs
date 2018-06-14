using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Hero : MonoBehaviour {

	public abstract void leftButtonDown ();

	public abstract void leftButtonUp ();

	public abstract void rightButtonDown ();

	public abstract void rightButtonUp ();

	public abstract void jump ();

	public abstract void attack ();

	public abstract void stop ();

	public abstract void moveCamera(Camera _camera);

}
