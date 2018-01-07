using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SocketIO;

public class TestFindSocket : MonoBehaviour {
	public GameObject monster;
	public Transform spawn;
	SocketIOComponent socket;
	
	// Use this for initialization
	void Start () {
		Debug.Log ("trying to find");

		GameObject socketObject = GameObject.Find("SocketIO");
		if(socketObject != null){
			Debug.Log ("found the object");

			socket = socketObject.GetComponent<SocketIOComponent>();
			if (socket != null) {
				Debug.Log ("found something named socket");
				socket.On("monsterSpawn", MonsterSpawn);

			}
		}
			
	}

	private void MonsterSpawn(SocketIOEvent evt){
		Debug.Log ("monster spawn called");
	}


	public void MonsterButtonPressed(string type){
		Debug.Log ("Button was clicked from monster: " + type + " !");
		socket.Emit("monsterSpawn");

		//Instantiate (monster, spawn.position, spawn.rotation);
	}


}
