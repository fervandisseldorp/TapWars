using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

public class GameController : MonoBehaviour {
	public int lives;
	//private SocketIOComponent socket;
	public GameObject socketObject;


	// Use this for initialization
	void Start () {
		Debug.Log ("not destroying gameobject socket on change");
	}

}
