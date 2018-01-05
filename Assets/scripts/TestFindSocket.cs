using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

public class TestFindSocket : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("trying to find controller");
		GameObject controller = GameObject.Find("Controller");

		//GameObject socketObject = controller.Find("SocketIO");


		if (controller != null) {
			Debug.Log ("found something named Controller");
		}
			
	}

}
