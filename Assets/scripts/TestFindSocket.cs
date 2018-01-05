﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SocketIO;

public class TestFindSocket : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		Debug.Log ("trying to find");
		GameObject socketObject = GameObject.Find("SocketIO");
		SocketIOComponent socket = socketObject.GetComponent<SocketIOComponent> ();

		//GameObject socketObject = controller.Find("SocketIO");

		if (socket != null) {
			Debug.Log ("found something named Controller");
			socket.On("monsterSpawn", MonsterSpawn);

		}
			
	}

	private void MonsterSpawn(SocketIOEvent evt){

	}



}
