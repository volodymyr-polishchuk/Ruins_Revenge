using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacterScript : MonoBehaviour {

	public PlayerController playerController;
	public Hero[] heros;
	private int count = 0;

	public void change() {
		playerController.hero = heros [(count++)%heros.Length];
	}
}
