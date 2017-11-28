using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterOnClick : MonoBehaviour {
	public GameObject monster;
	public Transform spawn;

	public void createMonster(string type){
		Debug.Log ("Button was clicked from monster: " + type + " !");
		Instantiate (monster, spawn.position, spawn.rotation);
	}

}
