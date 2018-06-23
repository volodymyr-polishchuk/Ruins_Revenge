using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpellScript : MonoBehaviour {

	public GameObject spell;
	public Transform parentTransform;

	public void SpawnSpell() {
		Instantiate (spell, parentTransform); 	
	}

}
