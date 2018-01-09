using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentControllerScript : MonoBehaviour {
	public static PersistentControllerScript control;
	public static GameObject socketObject;


	void Awake(){
		control = this;
		socketObject = GameObject.Find ("SocketIO");
		DontDestroyOnLoad (gameObject);
	}

}
