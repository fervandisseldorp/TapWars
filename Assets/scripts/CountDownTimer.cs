using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SocketIO;

public class CountDownTimer : MonoBehaviour {
	public Text textfield;
	bool gameStarts = false;
	float timeLeft = 3.0f;

	// Use this for initialization
	void Start () {
		Debug.Log ("trying to find");
		GameObject socketObject = GameObject.Find("SocketIO");
		SocketIOComponent socket = socketObject.GetComponent<SocketIOComponent> ();

		//GameObject socketObject = controller.Find("SocketIO");
		if (socket != null) {
			Debug.Log ("found something named Controller");
			socket.On("startCountDown", StartGame);

		}

	}
		
	void Update(){
		if(gameStarts == true){
			timeLeft -= Time.deltaTime;
			updateTextField (timeLeft);
		}
	}

	private void StartGame(SocketIOEvent evt){
		gameStarts = true;
	}

	private void updateTextField(float timeLeft){
		textfield.text = "" + timeLeft;
		if (timeLeft < 0) {
			Application.LoadLevel ("mainScene");
		}
	}

}
