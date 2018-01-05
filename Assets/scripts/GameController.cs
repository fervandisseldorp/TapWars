using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

public class GameController : MonoBehaviour {
	public int lives;
	//private SocketIOComponent socket;
	public GameObject socketObject;


	void awake(){
		DontDestroyOnLoad (this.gameObject);
	}

	// Use this for initialization
	void Start () {
		Debug.Log ("start in gamecontroller");
		//GameObject go = GameObject.Find ("SocketIO");
		SocketIOComponent socket = socketObject.GetComponent<SocketIOComponent>();

		Debug.Log ("not destroying gameobject socket on change");
	}

}
